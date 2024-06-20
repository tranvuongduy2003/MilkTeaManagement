using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Models.Chat;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class ConversationsRepository : RepositoryBase<Conversation, string, ApplicationDbContext>, IConversationsRepository
    {
        public ConversationsRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<List<ConversationDto>> GetConversationsBySenderId(string senderId)
        {
            try
            {
                var conversations = await _dbContext.Conversations
                    .AsNoTracking()
                    .Where(conversation => conversation.UserOneId.Equals(senderId) || conversation.UserTwoId.Equals(senderId))
                    .Join(_dbContext.Users.AsNoTracking(),
                        conversation => conversation.UserOneId,
                        user => user.Id,
                        (conversation, user) => new Conversation
                        {
                            Id = conversation.Id,
                            UserOneId = conversation.UserOneId,
                            UserTwoId = conversation.UserTwoId,
                            ConnectionId = conversation.ConnectionId,
                            LastMessage = conversation.LastMessage,
                            UserOne = user,
                            CreatedDate = conversation.CreatedDate,
                            UpdatedDate = conversation.UpdatedDate,
                        })
                    .Join(_dbContext.Users.AsNoTracking(),
                        conversation => conversation.UserTwoId,
                        user => user.Id,
                        (conversation, user) => new Conversation
                        {
                            Id = conversation.Id,
                            UserOneId = conversation.UserOneId,
                            UserTwoId = conversation.UserTwoId,
                            ConnectionId = conversation.ConnectionId,
                            LastMessage = conversation.LastMessage,
                            UserTwo = user,
                            UserOne = conversation.UserOne,
                            CreatedDate = conversation.CreatedDate,
                            UpdatedDate = conversation.UpdatedDate,
                        })
                    .OrderByDescending(conversation => conversation.UpdatedDate)
                    .Select(conversation => new ConversationDto
                    {
                        Id = conversation.Id,
                        Avatar = conversation.UserTwoId.Equals(senderId) ? conversation.UserOne.Avatar : conversation.UserTwo.Avatar,
                        Name = conversation.UserTwoId.Equals(senderId) ? conversation.UserOne.FullName : conversation.UserTwo.FullName,
                        ConnectionId = conversation.ConnectionId,
                        LastMessage = conversation.LastMessage,
                        SenderId = conversation.UserTwoId.Equals(senderId) ? conversation.UserTwoId : conversation.UserOneId,
                        ReceiverId = conversation.UserTwoId.Equals(senderId) ? conversation.UserOneId : conversation.UserTwoId,
                        CreatedDate = conversation.CreatedDate,
                        UpdatedDate = conversation.UpdatedDate,
                    })
                    .ToListAsync();
                return conversations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
