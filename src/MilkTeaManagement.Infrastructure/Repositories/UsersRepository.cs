using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class UsersRespository : RepositoryBase<User, string, ApplicationDbContext>, IUsersRepository
    {
        public UsersRespository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<User> CreateUserAsync(User user)
        {
            await CreateAsync(user);
            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            await UpdateAsync(user);
            return user;
        }

        public async Task<User> GetUserByUserNameAsync(string userName) =>
            await FindByCondition(x => x.UserName.Equals(userName)).FirstOrDefaultAsync();
    }
}
