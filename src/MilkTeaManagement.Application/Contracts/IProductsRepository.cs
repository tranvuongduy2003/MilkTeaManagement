using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IProductsRepository : IRepositoryBase<Product, string>
    {
        Task<List<Product>> FindAllProductsByFilter(Filter? filter);

        Task<Product> CreateProductAsync(Product product);

        Task<Product> UpdateProductAsync(Product product);
    }
}
