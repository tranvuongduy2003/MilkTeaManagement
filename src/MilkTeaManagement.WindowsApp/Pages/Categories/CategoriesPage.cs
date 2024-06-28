using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Models.Categories;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Forms.Categories;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.Pages.Categories
{
    public partial class CategoriesPage : Page
    {
        private readonly ICategoriesRepository _categoriesRepository;

        public CategoriesPage(ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();

            _categoriesRepository = categoriesRepository;

            CategoriesTable.CellDoubleClick += OnUpdateCategory;
        }

        public override async void OnLoad()
        {
            string searchText = SearchTextBox.Text;

            int filterComboboxSelectedIndex = CategoriesComboBox.SelectedIndex;

            if (filterComboboxSelectedIndex == -1)
            {
                filterComboboxSelectedIndex = 0;
            }

            var categories = await _categoriesRepository.FindAllCategoriesByFilter(
                new FilterInCategoriesPage
                {
                    SearchText = searchText,
                    FilterComboboxSelectedIndex = filterComboboxSelectedIndex
                });
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
                    CategoriesTable.Rows[i].Cells["CreatorId"].Value = category.CreatorId;
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

        //private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    string searchText = SearchTextBox.Text;
        //    int filterComboboxSelectedIndex = CategoriesComboBox.SelectedIndex;

        //    if (filterComboboxSelectedIndex == -1)
        //    {
        //        filterComboboxSelectedIndex = 0;
        //    }

        //    var categories = await _categoriesRepository.FindAllCategoriesByFilter(
        //        new FilterInCategoriesPage
        //        {
        //            SearchText = searchText,
        //            FilterComboboxSelectedIndex = filterComboboxSelectedIndex
        //        });
        //    await LoadCategoriesList(categories);
        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = Program.ServiceProvider.GetRequiredService<CreateCategoryForm>();

            if (createCategoryForm.ShowDialog() == DialogResult.OK)
            {
                this.OnLoad();
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CategoriesTable.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select category row to update!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedCell = CategoriesTable.SelectedCells[0];
            if (selectedCell.RowIndex >= 0)
            {
                UpdateCategoryForm updateCategoryForm = Program.ServiceProvider.GetRequiredService<UpdateCategoryForm>();
                var selectedRow = CategoriesTable.Rows[selectedCell.RowIndex];
                var category = new Category
                {
                    Id = selectedRow.Cells["Id"].Value.ToString(),
                    Poster = selectedRow.Cells["Poster"].Value.ToString(),
                    Name = selectedRow.Cells["CategoryName"].Value.ToString(),
                    CreatorId = selectedRow.Cells["CreatorId"].Value.ToString(),
                    CreatedDate = (DateTimeOffset)selectedRow.Cells["CreatedAt"].Value
                };
                updateCategoryForm.OnLoadCategory(category);

                if (updateCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    this.OnLoad();
                }
            }
        }

        private async void OnUpdateCategory(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateCategoryForm updateCategoryForm = Program.ServiceProvider.GetRequiredService<UpdateCategoryForm>();
                var selectedRow = CategoriesTable.Rows[e.RowIndex];
                var category = new Category
                {
                    Id = selectedRow.Cells["Id"].Value.ToString(),
                    Poster = selectedRow.Cells["Poster"].Value.ToString(),
                    Name = selectedRow.Cells["CategoryName"].Value.ToString(),
                    CreatorId = selectedRow.Cells["CreatorId"].Value.ToString(),
                    CreatedDate = (DateTimeOffset)selectedRow.Cells["CreatedAt"].Value
                };
                updateCategoryForm.OnLoadCategory(category);

                if (updateCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    this.OnLoad();
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoriesTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select category row to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCell = CategoriesTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = CategoriesTable.Rows[selectedCell.RowIndex];

                    var category = await _categoriesRepository.GetByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                    if (category == null)
                        throw new Exception("Category is not existed");


                    await _categoriesRepository.DeleteAsync(category);
                    await _categoriesRepository.SaveChangesAsync();

                    MessageBox.Show("Delete new category successfully!", "Success!", MessageBoxButtons.OK);
                    this.OnLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string searchText = SearchTextBox.Text;
                int filterComboboxSelectedIndex = CategoriesComboBox.SelectedIndex;

                if (filterComboboxSelectedIndex == -1)
                {
                    filterComboboxSelectedIndex = 0;
                }

                var categories = await _categoriesRepository.FindAllCategoriesByFilter(
                    new FilterInCategoriesPage
                    {
                        SearchText = searchText,
                        FilterComboboxSelectedIndex = filterComboboxSelectedIndex
                    });
                await LoadCategoriesList(categories);
            }
        }
    }
}
