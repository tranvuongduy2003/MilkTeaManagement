using MilkTeaManagement.Domain.Common.Interfaces;
using MilkTeaManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Users")]
    public class User : EntityAuditBase<string>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Avatar { get; set; }

        public EGender? Gender { get; set; }

        public DateTimeOffset? DOB { get; set; }

        public string PhoneNumber { get; set; }

        public EUserStatus Status { get; set; } = EUserStatus.ACTIVE;
    }
}
