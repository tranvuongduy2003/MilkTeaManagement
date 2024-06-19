using System.ComponentModel.DataAnnotations;

namespace MilkTeaManagement.Application.Common.Models.Chat
{
    public class MessageDto
    {
        public string Id { get; set; }

        public string? Content { get; set; }

        public string? Video { get; set; }

        public string? Image { get; set; }

        public string? Icon { get; set; }

        [Required]
        [MaxLength(50)]
        public string ConversationId { get; set; }

        [Required]
        [MaxLength(50)]
        public string SenderId { get; set; }

        [MaxLength(50)]
        public string? ReceiverId { get; set; }
    }
}
