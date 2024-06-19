using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Categories;
using MilkTeaManagement.Application.Contracts;
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
            var categories = await _categoriesRepository.FindAllCategoriesByFilter(null);
            await LoadCategoriesList(categories);
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
            if (CategoriesComboBox.SelectedIndex == 0)
            {
                var categories = await _categoriesRepository.FindAllCategoriesByFilter(null);
                await LoadCategoriesList(categories);
            }
            else
            {
                
            }
        }
    }
}
