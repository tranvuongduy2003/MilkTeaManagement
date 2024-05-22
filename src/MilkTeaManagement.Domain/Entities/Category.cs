using MilkTeaManagement.Domain.Common.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Categories")]
    public class Category : EntityAuditBase<string>
    {
        public string Name { get; set; }

        public string Poster { get; set; }

        public string CreatorId { get; set; }
    }
}
