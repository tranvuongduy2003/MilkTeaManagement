using MilkTeaManagement.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("OrderItems")]
    public class OrderItem : EntityAuditBase<string>
    {
        [Required]
        [MaxLength(50)]
        public string ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrderId { get; set; }

        public decimal SubTotalPrice { get; set; }

        public int Quantity { get; set; }

        public string? Description { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
