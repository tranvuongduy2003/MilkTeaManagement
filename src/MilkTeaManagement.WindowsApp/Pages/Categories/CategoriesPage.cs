using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Models.Categories;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Infrastructure.Repositories;
using MilkTeaManagement.WindowsApp.Forms;
using MilkTeaManagement.WindowsApp.Forms.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTeaManagement.WindowsApp.Pages.Categories
{
    public partial class CategoriesPage : UserControl
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesPage(ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();

            _categoriesRepository = categoriesRepository;
        }

        public async void OnLoad()
        {
            CategoriesComboBox.SelectedIndex = 0;
        }

        private async Task LoadCategoriesList(List<CategoriesDTO> categories)
        {
            CategoriesTable.Rows.Clear();
            if (categories.Count > 0)
            {
                CategoriesTable.Rows.Add(categories.Count);
                for (int i = 0; i < categories.Count; i++)
                {
                    var category = categories[i];
                    CategoriesTable.Rows[i].Cells["Id"].Value = category.Id;
                    CategoriesTable.Rows[i].Cells["CategoryName"].Value = category.Name;
                    CategoriesTable.Rows[i].Cells["Poster"].Value = category.Poster;
                    CategoriesTable.Rows[i].Cells["Creator"].Value = category.Creator;
                    CategoriesTable.Rows[i].Cells["CreatedAt"].Value = category.CreatedDate;
                }
            }
        }

        private async void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;
            int filterComboboxSelectedIndex = CategoriesComboBox.SelectedIndex;

            var categories = await _categoriesRepository.FindAllCategoriesByFilter(
                new FilterInCategoriesPage
                {
                    SearchText = searchText,
                    FilterComboboxSelectedIndex = filterComboboxSelectedIndex
                });
            await LoadCategoriesList(categories);
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text;
            int filterComboboxSelectedIndex = CategoriesComboBox.SelectedIndex;

            var categories = await _categoriesRepository.FindAllCategoriesByFilter(
                new FilterInCategoriesPage
                {
                    SearchText = searchText,
                    FilterComboboxSelectedIndex = filterComboboxSelectedIndex
                });
            await LoadCategoriesList(categories);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = Program.ServiceProvider.GetRequiredService<CreateCategoryForm>();

            if (createCategoryForm.ShowDialog() == DialogResult.OK)
            {
                this.OnLoad();
            }
        }
    }
}
