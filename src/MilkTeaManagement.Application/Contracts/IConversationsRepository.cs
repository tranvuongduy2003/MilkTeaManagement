using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IConversationsRepository : IRepositoryBase<Conversation, string>
    {
        Task<List<ConversationDto>> GetConversationsBySenderId(string senderId);
    }
}
