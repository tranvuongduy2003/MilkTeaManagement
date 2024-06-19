using Infrastructure.Common;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class MessagesRepository : RepositoryBase<Message, string, ApplicationDbContext>, IMessagesRepository
    {
        public MessagesRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }
    }
}
