namespace MilkTeaManagement.Application.Common.Models.Chat
{
    public class JoinChatRoomRequest
    {
        public string? ConversationId { get; set; }

        public string? SenderId { get; set; }

        public string? ReceiverId { get; set; }
    }
}
