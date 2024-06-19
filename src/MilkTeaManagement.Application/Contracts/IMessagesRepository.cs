using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IMessagesRepository : IRepositoryBase<Message, string>
    {
    }
}
