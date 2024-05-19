using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Application.Contracts
{
    public class UsersRespository : RepositoryBase<User, long, ApplicationDbContext>, IUsersRepository
    {
        public UsersRespository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<IEnumerable<User>> GetUsersByUserNameAsync(string userName) =>
            await FindByCondition(x => x.UserName.Equals(userName)).ToListAsync();

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
    }
}
