using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.WindowsApp.Extensions;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.Pages.Products
{
    public partial class ProductsPage : UserControl
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsPage(IProductsRepository productsRepository)
        {
            InitializeComponent();
            _productsRepository = productsRepository;
        }

        public async void OnLoad()
        {
            var products = await _productsRepository.FindAll().ToListAsync();

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
}
