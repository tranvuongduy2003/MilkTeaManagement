using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.UserControls.Home;

namespace MilkTeaManagement.WindowsApp.Pages.Home
{
    public partial class HomePage : UserControl
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IProductsRepository _productsRepository;

        private string SearchText { get; set; } = string.Empty;
        private string CategoryId { get; set; } = string.Empty;

        public HomePage(ICategoriesRepository categoriesRepository, IProductsRepository productsRepository)
        {
            InitializeComponent();
            _categoriesRepository = categoriesRepository;
            _productsRepository = productsRepository;
        }

        public async void OnLoad()
        {
            var categories = _categoriesRepository.FindAll().ToList();
            await LoadCategoriesList(categories);

            var products = _productsRepository.FindAll().ToList();
            await LoadProductsList(products);
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ((TextBox)sender).Text;
            SearchText = searchText;
            var products = await _productsRepository.FindAllProductsByFilter(new Filter { Search = SearchText, CategoryId = CategoryId });
            await LoadProductsList(products);
        }

        public async void CategoryItem_Clicked(object sender, EventArgs e)
        {
            var category = ((CategoryItem)sender).Category;
            CategoryId = category.Id;
            var products = await _productsRepository.FindAllProductsByFilter(new Filter { Search = SearchText, CategoryId = CategoryId });
            await LoadProductsList(products);
        }

        private async Task LoadProductsList(IEnumerable<Product> products)
        {
            this.ResultQuantity.Text = $"{products.Count()} Results";
            ProductsPanel.Controls.Clear();
            foreach (var product in products)
            {
                ProductItem productItem = new ProductItem();
                await productItem.OnLoad(product);
                ProductsPanel.Controls.Add(productItem);
            }
        }
        private async Task LoadCategoriesList(List<Category> categories)
        {
            CategoriesPanel.Controls.Clear();
            foreach (var category in categories)
            {
                CategoryItem categoryItem = new CategoryItem();
                await categoryItem.OnLoad(category);
                categoryItem.OnLoadClickEvent(CategoryItem_Clicked);
                CategoriesPanel.Controls.Add(categoryItem);
            }
        }
    }
}
