using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.WindowsApp.Forms
{
    public partial class CreateProductForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly IProductsRepository _productsRepository;
        private readonly ICategoriesRepository _categoriesRepository;

        public List<Category> Categories { get; set; } = new List<Category>();
        private string PosterFilePath { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;

        public CreateProductForm(IAzureBlobService azureBlobService, IProductsRepository productsRepository, ICategoriesRepository categoriesRepository)
        {
            InitializeComponent();
            _azureBlobService = azureBlobService;
            _productsRepository = productsRepository;
            _categoriesRepository = categoriesRepository;

            this.OnLoad();
        }

        public async void OnLoad()
        {
            var categories = await _categoriesRepository.FindAll().ToListAsync();
            Categories = categories;
            this.CategoriesComboBox.Items.Clear();
            foreach (var category in categories)
                this.CategoriesComboBox.Items.Add(category.Name);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void poster_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Poster.BackgroundImage = new Bitmap(openFileDialog.FileName);
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
                    Name = name,
                    Poster = uploadedFile.Blob.Uri,
                    Price = decimal.Parse(price),
                    Description = description,
                    CategoryId = CategoryId,
                    Status = EProductStatus.AVAILABLE,
                };
                await _productsRepository.CreateAsync(product);

                await _productsRepository.SaveChangesAsync();

                MessageBox.Show("Create new product successfully!", "Success!", MessageBoxButtons.OK);
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
    }
}
