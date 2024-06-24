using MilkTeaManagement.Domain.Common;
using MilkTeaManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Shifts")]
    public class Shift : EntityBase<string>
    {
        [Required]
        public string EmployeeId { get; set; }

        public EDayTime Time { get; set; }

        public bool Mo { get; set; } = false;

        public bool Tu { get; set; } = false;

        public bool We { get; set; } = false;

        public bool Th { get; set; } = false;

        public bool Fr { get; set; } = false;

        public bool Sa { get; set; } = false;

        public bool Su { get; set; } = false;

        [ForeignKey("EmployeeId")]
        public virtual User Employee { get; set; }
    }
}
