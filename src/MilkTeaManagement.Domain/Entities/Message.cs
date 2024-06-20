using MilkTeaManagement.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Messages")]
    public class Message : EntityAuditBase<string>
    {
        [MaxLength(10000)]
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

        [ForeignKey("ConversationId")]
        public virtual Conversation Conversation { get; set; }

        [ForeignKey("SenderId")]
        public virtual User Sender { get; set; }

        [ForeignKey("ReceiverId")]
        public virtual User? Receiver { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
