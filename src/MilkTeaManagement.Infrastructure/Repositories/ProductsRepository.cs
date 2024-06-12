using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class ProductsRepository : RepositoryBase<Product, string, ApplicationDbContext>, IProductsRepository
    {
        public ProductsRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<List<Product>> FindAllProductsByFilter(Filter filter)
        {
            var products = new List<Product>();

            if (!filter.Search.IsNullOrEmpty() && !filter.CategoryId.IsNullOrEmpty())
            {
                products = await FindByCondition(x => x.Name.ToLower().Contains(filter.Search.ToLower()) && x.CategoryId.Equals(filter.CategoryId)).ToListAsync();
            }
            else if (!filter.Search.IsNullOrEmpty())
            {
                products = await FindByCondition(x => x.Name.ToLower().Contains(filter.Search.ToLower())).ToListAsync();
            }
            else if (!filter.CategoryId.IsNullOrEmpty())
            {
                products = await FindByCondition(x => x.CategoryId.Equals(filter.CategoryId)).ToListAsync();
            }

            return products;
        }

        public Task<Product> CreateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
