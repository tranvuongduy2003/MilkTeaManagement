using MilkTeaManagement.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Conversations")]
    public class Conversation : EntityAuditBase<string>
    {
        public string? LastMessage { get; set; }

        [MaxLength(50)]
        public string? UserOneId { get; set; }

        [MaxLength(50)]
        public string? UserTwoId { get; set; }

        [MaxLength(50)]
        public string? ConnectionId { get; set; }

        [ForeignKey("UserOneId")]
        public virtual User? UserOne { get; set; }

        [ForeignKey("UserTwoId")]
        public virtual User? UserTwo { get; set; }

        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
