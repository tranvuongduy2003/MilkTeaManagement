using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Extensions;
using MilkTeaManagement.WindowsApp.Forms;
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

            var products = await _productsRepository.FindAll().ToListAsync();
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
                await Parallel.ForEachAsync(
                    products.Select((x, i) => (Value: x, Index: i)),
                    new ParallelOptions
                    {
                        MaxDegreeOfParallelism = 20
                    },
                    async (x, _) =>
                    {
                        var product = x.Value;
                        var index = x.Index;
                        ProductsTable.Rows[index].Cells["ProductName"].Value = product.Name;
                        ProductsTable.Rows[index].Cells["Status"].Value = product.Status;
                        ProductsTable.Rows[index].Cells["Category"].Value = product.CategoryId;
                        ProductsTable.Rows[index].Cells["Price"].Value = ConvertCurrency.ToVND(product.Price);
                        ProductsTable.Rows[index].Cells["CreatedAt"].Value = product.CreatedDate;
                        ProductsTable.Rows[index].Cells["Creator"].Value = product.CreatorId;
                        ProductsTable.Rows[index].Cells["Poster"].Value = await ImageExtensions.GetImageFromUrl(product.Poster);
                    });
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new();

            createProductForm.ShowDialog();
        }
    }
}
