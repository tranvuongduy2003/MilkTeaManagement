using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    public partial class ProductItem : UserControl
    {
        public Product? Product { get; set; } = null!;

        public ProductItem()
        {
            InitializeComponent();
        }

        public async Task OnLoad(Product product)
        {
            Product = product;
            this.ProductName.Text = product.Name;
            this.ProductImage.ImageLocation = product.Poster;
            this.ProductDescription.Text = product.Description;
            this.ProductPrice.Text = ConvertCurrency.ToVND(product.Price);
        }

        public async Task OnAddToCart(EventHandler handler)
        {
            this.AddToBillButton.Click += new EventHandler((object sender, EventArgs e) =>
            {
                handler(Product, e);
            });
        }
    }
}
