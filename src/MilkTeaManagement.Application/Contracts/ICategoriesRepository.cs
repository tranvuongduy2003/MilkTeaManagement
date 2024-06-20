using MilkTeaManagement.Application.Common.Models.Categories;
using MilkTeaManagement.Application.Common.Models.Filter;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface ICategoriesRepository : IRepositoryBase<Category, string>
    {
        Task<List<CategoriesDTO>> FindAllCategoriesByFilter(FilterInCategoriesPage? filter);

        Task<Category> CreateCategoryAsync(Category category);

        Task<Category> UpdateCategoryAsync(Category category);
    }
}
