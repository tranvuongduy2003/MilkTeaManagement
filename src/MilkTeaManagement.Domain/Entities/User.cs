using Microsoft.AspNetCore.Identity;
using MilkTeaManagement.Domain.Common.Interfaces;
using MilkTeaManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MilkTeaManagement.Domain.Entities
{
    [Table("Users")]
    public class User : IdentityUser, IAuditable
    {
        public string FullName { get; set; }

        public string Avatar { get; set; }

        public EGender? Gender { get; set; }

        public DateTimeOffset? DOB { get; set; }

        public string PhoneNumber { get; set; }

        public EUserStatus Status { get; set; } = EUserStatus.ACTIVE;

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
