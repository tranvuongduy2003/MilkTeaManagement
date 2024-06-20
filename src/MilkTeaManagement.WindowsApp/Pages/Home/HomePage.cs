using Microsoft.AspNetCore.Identity;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Common.Models.Orders;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Helpers;
using MilkTeaManagement.WindowsApp.UserControls.Home;

namespace MilkTeaManagement.WindowsApp.Pages.Home
{
    public partial class HomePage : UserControl
    {
        private readonly ICategoriesRepository _categoriesRepository;
        private readonly IProductsRepository _productsRepository;
        private readonly IOrdersRepository _ordersRepository;
        private readonly SignInManager<User> _signInManager;

        private List<OrderItem> OrderItems = new List<OrderItem>();
        private string SearchText { get; set; } = string.Empty;
        private string CategoryId { get; set; } = string.Empty;
        private int DiscountPercentValue { get; set; } = 0;

        public HomePage(ICategoriesRepository categoriesRepository, IProductsRepository productsRepository, IOrdersRepository ordersRepository, SignInManager<User> signInManager)
        {
            InitializeComponent();
            _categoriesRepository = categoriesRepository;
            _productsRepository = productsRepository;
            _ordersRepository = ordersRepository;
            this._signInManager = signInManager;
        }

        public async void OnLoad()
        {
            this.Role.Text = Program.UserIdentity.Role;
            this.Avatar.ImageLocation = Program.UserIdentity.Avatar;
            this.FullName.Text = Program.UserIdentity.FullName;

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
                await productItem.OnAddToCart(OnAddProductToCart);
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

        public void OnAddProductToCart(object sender, EventArgs e)
        {
            Product product = (Product)sender;
            var billItems = invoicePanel.Controls
                .Find(nameof(BillItem), true)
                .Select(c => c as BillItem)
                .ToList();
            var billItemControl = billItems.Find(x => x.OrderItem.ProductId == product.Id);

            if (billItemControl == null)
            {
                BillItem billItem = new BillItem();
                billItem.OnLoad(product);
                billItem.OnRemove = OnRemoveProductFromCart;
                billItem.OnIncrease = new EventHandler((sender, e) => ChangeTotalPrice());
                billItem.OnDecrease = new EventHandler((sender, e) => ChangeTotalPrice());
                this.invoicePanel.Controls.Add(billItem);
                OrderItems.Add(billItem.OrderItem);
            }
            else
            {
                var handler = new EventHandler(billItemControl.increase_Click);
                handler.Invoke(this, EventArgs.Empty);
                var orderItem = OrderItems.FirstOrDefault(item => item.ProductId == billItemControl.OrderItem.ProductId);
                orderItem = billItemControl.OrderItem;
            }
            ChangeTotalPrice();
        }

        public void OnRemoveProductFromCart(object sender, EventArgs e)
        {
            OrderItem orderItem = (OrderItem)sender;
            var billItems = invoicePanel.Controls
                .Find(nameof(BillItem), true)
                .Select(c => c as BillItem)
                .ToList();
            var billItemControl = billItems.Find(x => x.OrderItem.ProductId == orderItem.ProductId);
            invoicePanel.Controls.Remove(billItemControl);
            var foundOrderItem = OrderItems.FirstOrDefault(item => item.ProductId == billItemControl.OrderItem.ProductId);
            OrderItems.Remove(foundOrderItem);
            ChangeTotalPrice();
        }

        private void ChangeTotalPrice()
        {
            var subTotal = OrderItems.Sum(item => item.SubTotalPrice);
            var discountPrice = ((decimal)DiscountPercentValue / 100) * subTotal;
            var total = subTotal - discountPrice;
            this.SubTotal.Text = ConvertCurrency.ToVND(subTotal);
            this.Discount.Text = ConvertCurrency.ToVND(discountPrice);
            this.Total.Text = ConvertCurrency.ToVND(total);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            DiscountPercentValue = int.Parse(this.DiscountPercent.Text);
            ChangeTotalPrice();
        }

        private async void CheckoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var subTotal = OrderItems.Sum(item => item.SubTotalPrice);
                var discountPrice = ((decimal)DiscountPercentValue / 100) * subTotal;
                var total = subTotal - discountPrice;

                var request = new CheckoutRequest
                {
                    CustomerPhone = this.CustomerPhone.Text,
                    Discount = (float)(DiscountPercentValue / 100),
                    EmployeeId = Program.UserIdentity.Id,
                    TotalPrice = total,
                    OrderItems = OrderItems,
                };

                await _ordersRepository.CheckoutAsync(request);

                MessageBox.Show("Checkout successfully!", "Success!", MessageBoxButtons.OK);

                invoicePanel.Controls.Clear();
                this.SubTotal.Text = "0 VNĐ";
                this.Discount.Text = "0 VNĐ";
                this.Total.Text = "0 VNĐ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
