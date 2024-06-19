namespace MilkTeaManagement.Application.Common.Models.Chat
{
    public class SendMessageRequest
    {
        public string? Content { get; set; }

        public string? Video { get; set; }

        public string? Image { get; set; }

        public string? Icon { get; set; }

        public string ConversationId { get; set; }

        public string SenderId { get; set; }

        public string? ReceiverId { get; set; }
    }
}
