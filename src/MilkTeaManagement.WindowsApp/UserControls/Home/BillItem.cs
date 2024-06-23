using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    public partial class BillItem : UserControl
    {
        public OrderItem OrderItem { get; set; }

        public EventHandler OnRemove { get; set; }

        public EventHandler OnDecrease { get; set; }

        public EventHandler OnIncrease { get; set; }

        public BillItem()
        {
            InitializeComponent();
        }

        public async void OnLoad(Product product)
        {
            OrderItem = new OrderItem
            {
                ProductId = product.Id,
                SubTotalPrice = product.Price,
                Quantity = 1,
                Product = product,
            };
            this.poster.ImageLocation = product.Poster;
            this.poster.SizeMode = PictureBoxSizeMode.Zoom;
            this.poster.BackgroundImage = null;
            this.name.Text = product.Name;
            this.price.Text = ConvertCurrency.ToVND(product.Price);
            this.quantity.Text = "1";
            this.subTotal.Text = this.price.Text;
        }

        public void decrease_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(this.quantity.Text);
            if (quantity > 1)
            {
                this.quantity.Text = (--quantity).ToString();
                OrderItem.Quantity = quantity;
                OrderItem.SubTotalPrice = quantity * OrderItem.Product.Price;
                this.subTotal.Text = ConvertCurrency.ToVND(OrderItem.SubTotalPrice);
            }
            else
            {
                OnRemove.Invoke(OrderItem, EventArgs.Empty);
            }
            OnDecrease.Invoke(this, EventArgs.Empty);
        }

        public void increase_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(this.quantity.Text);
            this.quantity.Text = (++quantity).ToString();
            OrderItem.Quantity = quantity;
            OrderItem.SubTotalPrice = quantity * OrderItem.Product.Price;
            this.subTotal.Text = ConvertCurrency.ToVND(OrderItem.SubTotalPrice);
            OnIncrease.Invoke(this, EventArgs.Empty);
        }

        public void remove_Click(object sender, EventArgs e)
        {
            OnRemove.Invoke(OrderItem, EventArgs.Empty);
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            var description = this.description.Text;
            OrderItem.Description = description;
        }
    }
}
