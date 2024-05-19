using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IUsersRepository : IRepositoryBase<User, string>
    {
        Task<User> GetUserByUserNameAsync(string userName);

        Task<User> CreateUserAsync(User user);

        Task<User> UpdateUserAsync(User user);
    }
}
