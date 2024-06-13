using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;
using MilkTeaManagement.WindowsApp.Forms;
using MilkTeaManagement.WindowsApp.Forms.Products;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.Pages.Products
{
    public partial class ProductsPage : UserControl
    {
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public List<Category> Categories { get; set; } = new List<Category>();

        public string Search { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;

        public CancellationTokenSource cancellationToken { get; set; } = new();

        public ProductsPage(IProductsRepository productsRepository, ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;
        }

        public async void OnLoad()
        {
            var categories = await _categoriesRepository.FindAll().ToListAsync();
            Categories = categories;
            this.CategoriesComboBox.Items.Clear();
            foreach (var category in categories)
                this.CategoriesComboBox.Items.Add(category.Name);

            var products = await _productsRepository.FindAllProductsByFilter(null);
            await LoadProductsList(products);
        }

        private async void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoryName = ((ComboBox)sender).Text;
            CategoryId = Categories.FirstOrDefault(c => c.Name.Equals(categoryName))?.Id ?? "";

            var products = await _productsRepository.FindAllProductsByFilter(new Filter { Search = Search, CategoryId = CategoryId });
            await LoadProductsList(products);
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ((TextBox)sender).Text;
            Search = searchText;

            var products = await _productsRepository.FindAllProductsByFilter(new Filter { Search = Search, CategoryId = CategoryId });
            await LoadProductsList(products);
        }

        private async Task LoadProductsList(List<Product> products)
        {
            ProductsTable.Rows.Clear();
            if (products.Count > 0)
            {
                ProductsTable.Rows.Add(products.Count);
                for (int index = 0; index < products.Count; index++)
                {
                    var product = products[index];
                    ProductsTable.Rows[index].Cells["Id"].Value = product.Id;
                    ProductsTable.Rows[index].Cells["ProductCategoryId"].Value = product.CategoryId;
                    ProductsTable.Rows[index].Cells["Description"].Value = product.Description;
                    ProductsTable.Rows[index].Cells["Poster"].Value = product.Poster;
                    ProductsTable.Rows[index].Cells["ProductName"].Value = product.Name;
                    ProductsTable.Rows[index].Cells["Status"].Value = product.Status;
                    ProductsTable.Rows[index].Cells["Category"].Value = product.Category?.Name ?? "";
                    ProductsTable.Rows[index].Cells["Price"].Value = ConvertCurrency.ToVND(product.Price);
                    ProductsTable.Rows[index].Cells["CreatedAt"].Value = product.CreatedDate;
                    ProductsTable.Rows[index].Cells["ProductPrice"].Value = product.Price;
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = Program.ServiceProvider.GetRequiredService<CreateProductForm>();

            if (createProductForm.ShowDialog() == DialogResult.OK)
            {
                this.OnLoad();
            }
        }

        private async void update_Click(object sender, EventArgs e)
        {
            if (ProductsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select product row to update!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateProductForm updateProductForm = Program.ServiceProvider.GetRequiredService<UpdateProductForm>();
            var selectedRow = ProductsTable.SelectedRows[0];
            var product = new Product
            {
                Id = selectedRow.Cells["Id"].Value.ToString(),
                CategoryId = selectedRow.Cells["ProductCategoryId"].Value.ToString(),
                Description = selectedRow.Cells["Description"].Value.ToString(),
                Poster = selectedRow.Cells["Poster"].Value.ToString(),
                Name = selectedRow.Cells["ProductName"].Value.ToString(),
                Status = selectedRow.Cells["Status"].Value == nameof(EProductStatus.AVAILABLE) ? EProductStatus.AVAILABLE : EProductStatus.UNAVAILABLE,
                Price = decimal.Parse(selectedRow.Cells["ProductPrice"].Value.ToString()),

            };
            updateProductForm.OnLoadProduct(product);

            if (updateProductForm.ShowDialog() == DialogResult.OK)
            {
                this.OnLoad();
            }
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsTable.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select product row to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedRow = ProductsTable.SelectedRows[0];

                var product = await _productsRepository.GetByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                if (product == null)
                    throw new Exception("Product is not existed");

                await _productsRepository.DeleteAsync(product);
                await _productsRepository.SaveChangesAsync();

                MessageBox.Show("Delete new product successfully!", "Success!", MessageBoxButtons.OK);
                this.OnLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}