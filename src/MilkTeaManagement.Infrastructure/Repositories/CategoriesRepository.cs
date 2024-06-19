using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Categories;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class CategoriesRepository : RepositoryBase<Category, string, ApplicationDbContext>, ICategoriesRepository
    {
        public CategoriesRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public Task<Category> CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoriesDTO>> FindAllCategoriesByFilter(FilterInCategoriesPage? filter)
        {
            var categories = new List<CategoriesDTO>();

            // Find all categories which search text is empty and filter a -> z
            if (filter == null)
            {
                categories = await _dbContext.Categories.AsQueryable().Join(_dbContext.Users, c => c.CreatorId, u => u.Id, (c, u) => new CategoriesDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Poster = c.Poster,
                    CreatorId = c.CreatorId,
                    Creator = u.FullName,
                    CreatedDate = c.CreatedDate.ToString("dd/MM/yyyy")
                }).OrderBy(dto => dto.Name).ToListAsync();
            }

            return categories;
        }

        public Task<Category> UpdateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
