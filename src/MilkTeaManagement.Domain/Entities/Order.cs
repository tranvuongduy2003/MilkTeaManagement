using MilkTeaManagement.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Orders")]
    public class Order : EntityAuditBase<string>
    {
        public decimal TotalPrice { get; set; }

        public float? Discount { get; set; }

        public float? Tax { get; set; }

        public string? CustomerPhone { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual User Employee { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
