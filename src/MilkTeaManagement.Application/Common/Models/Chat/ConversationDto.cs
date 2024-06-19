using System.ComponentModel.DataAnnotations;

namespace MilkTeaManagement.Application.Common.Models.Chat
{
    public class ConversationDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Avatar { get; set; }

        public string? LastMessage { get; set; }

        [MaxLength(50)]
        public string? ReceiverId { get; set; }

        [MaxLength(50)]
        public string? SenderId { get; set; }

        [MaxLength(50)]
        public string? ConnectionId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
