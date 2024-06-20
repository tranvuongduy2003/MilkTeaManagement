using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;
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
    public partial class CreateCategoryForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly ICategoriesRepository _categoriesRepository;

        private string PosterFilePath { get; set; } = string.Empty;

        public CreateCategoryForm(IAzureBlobService azureBlobService, ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();

            _azureBlobService = azureBlobService;
            _categoriesRepository = categoriesRepository;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Poster.BackgroundImage = Properties.Resources.upload_image1;
            PosterFilePath = string.Empty;
            tbName.Clear();
            this.Close();
        }

        private void Poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Poster.BackgroundImage = new Bitmap(openFileDialog.FileName);
                PosterFilePath = openFileDialog.FileName;
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
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
                    Name = name,
                    Poster = uploadedFile.Blob.Uri,
                    CreatorId = "94d6bd66-70bc-4163-a2a6-cf7a1aaf270f",
                };
                await _categoriesRepository.CreateAsync(category);

                await _categoriesRepository.SaveChangesAsync();

                MessageBox.Show("Create new category successfully!", "Success!", MessageBoxButtons.OK);

                Poster.BackgroundImage = Properties.Resources.upload_image1;
                PosterFilePath = string.Empty;
                tbName.Clear();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
