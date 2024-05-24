namespace MilkTeaManagement.WindowsApp.UserControls.Products
{
    public class ProductImage : PictureBox
    {
        public ProductImage(string url)
        {
            this.Width = 90;
            this.Height = 130;
            this.Margin = new Padding(0);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ImageLocation = url;
        }
    }
}
