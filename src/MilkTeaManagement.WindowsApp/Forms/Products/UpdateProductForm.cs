using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.WindowsApp.Forms.Products
{
    public partial class UpdateProductForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public List<Category> Categories { get; set; } = new List<Category>();
        private string PosterFilePath { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        public Product Product { get; set; }

        public UpdateProductForm(IAzureBlobService azureBlobService, IProductsRepository productsRepository, ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();
            _azureBlobService = azureBlobService;
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
        }

        public async void OnLoadProduct(string productId)
        {
            var product = await _productsRepository.GetByIdAsync(productId);
            var categories = await _categoriesRepository.FindAll().ToListAsync();
            Categories = categories;
            this.CategoriesComboBox.Items.Clear();
            foreach (var category in categories)
                this.CategoriesComboBox.Items.Add(category.Name);
            var selectedCategory = Categories.Find(c => c.Id == product.CategoryId);
            CategoriesComboBox.Text = selectedCategory.Name;
            NameTextbox.Text = product.Name;
            PriceTextbox.Text = product.Price.ToString();
            DiscountPriceTextBox.Text = (product.DiscountPrice ?? 0).ToString();
            DescriptionTextbox.Text = product.Description;
            Poster.ImageLocation = product.Poster;
            Poster.SizeMode = PictureBoxSizeMode.Zoom;
            PosterFilePath = product.Poster;
            Product = product;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Poster.Image = Properties.Resources.upload_image1;
        }

        private void poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Poster.ImageLocation = openFileDialog.FileName;
                Poster.SizeMode = PictureBoxSizeMode.Zoom;
                PosterFilePath = openFileDialog.FileName;
            }
        }

        private async void create_Click(object sender, EventArgs e)
        {
            try
            {
                var name = NameTextbox.Text;
                var price = PriceTextbox.Text;
                var description = DescriptionTextbox.Text;
                var discount = DiscountPriceTextBox.Text;

                string error = "";

                if (PosterFilePath.IsNullOrEmpty())
                    error += "**Poster is required\n\n";
                if (name.IsNullOrEmpty())
                    error += "**Name is required\n\n";
                if (price.IsNullOrEmpty())
                    error += "**Price is required\n\n";
                if (CategoryId.IsNullOrEmpty())
                    error += "**Category is required\n\n";
                if (description.IsNullOrEmpty())
                    error += "**Desciption is required";

                if (!error.IsNullOrEmpty())
                {
                    throw new Exception(error);
                }

                var uploadedFile = await _azureBlobService.UploadAsync(PosterFilePath);
                var product = new Product
                {
                    Id = Product.Id,
                    Name = name,
                    Poster = uploadedFile.Blob.Uri,
                    Price = decimal.Parse(price),
                    DiscountPrice = discount.IsNullOrEmpty() ? null : decimal.Parse(discount),
                    Description = description,
                    CategoryId = CategoryId,
                };
                await _productsRepository.UpdateAsync(product);

                await _productsRepository.SaveChangesAsync();

                MessageBox.Show("Update product successfully!", "Success!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CategoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categoryName = ((ComboBox)sender).Text;
            CategoryId = Categories.FirstOrDefault(c => c.Name.Equals(categoryName))?.Id ?? "";
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = await _productsRepository.GetByIdAsync(Product.Id);

                if (product == null)
                    throw new Exception("Product is not existed");

                await _productsRepository.DeleteAsync(product);
                await _productsRepository.SaveChangesAsync();

                MessageBox.Show("Delete product successfully!", "Success!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
