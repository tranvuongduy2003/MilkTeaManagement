using MilkTeaManagement.Domain.Common.Interfaces;
using MilkTeaManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Products")]
    public class Product : EntityAuditBase<string>
    {
        public string Poster { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public EProductStatus Status { get; set; }

        public string CreatorId { get; set; }

        public string CategoryId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual User Creator { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
