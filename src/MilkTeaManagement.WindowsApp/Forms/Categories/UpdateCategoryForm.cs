using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaManagement.WindowsApp.Forms.Categories
{
    public partial class UpdateCategoryForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly ICategoriesRepository _categoriesRepository;

        private string PosterFilePath { get; set; } = string.Empty;
        public Category Category { get; set; }

        public UpdateCategoryForm(IAzureBlobService azureBlobService, ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();

            _azureBlobService = azureBlobService;
            _categoriesRepository = categoriesRepository;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Poster.Image = Properties.Resources.upload_image1;
        }

        public void OnLoadCategory(Category category)
        {
            tbName.Text = category.Name;
            Poster.ImageLocation = category.Poster;
            Poster.SizeMode = PictureBoxSizeMode.Zoom;
            PosterFilePath = category.Poster;
            Category = category;
        }

        private void Poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Poster.ImageLocation = openFileDialog.FileName;
                Poster.SizeMode = PictureBoxSizeMode.Zoom;
                PosterFilePath = openFileDialog.FileName;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbName.Text;

                string error = "";

                if (PosterFilePath.IsNullOrEmpty())
                    error += "**Poster is required\n\n";
                if (name.IsNullOrEmpty())
                    error += "**Name is required\n\n";

                if (!error.IsNullOrEmpty())
                {
                    throw new Exception(error);
                }

                var uploadedFile = await _azureBlobService.UploadAsync(PosterFilePath);
                var category = new Category
                {
                    Id = Category.Id,
                    Name = name,
                    Poster = uploadedFile.Blob.Uri,
                    CreatorId = "94d6bd66-70bc-4163-a2a6-cf7a1aaf270f",
                    CreatedDate = Category.CreatedDate,
                    UpdatedDate = DateTimeOffset.Now
                };
                await _categoriesRepository.UpdateAsync(category);

                await _categoriesRepository.SaveChangesAsync();

                MessageBox.Show("Update new category successfully!", "Success!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = await _categoriesRepository.GetByIdAsync(Category.Id);

                if (category == null)
                    throw new Exception("Category is not existed");

                await _categoriesRepository.DeleteAsync(category);
                await _categoriesRepository.SaveChangesAsync();

                MessageBox.Show("Delete new category successfully!", "Success!", MessageBoxButtons.OK);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
