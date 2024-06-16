using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.Domain.ValueObjetcs
{
    public static class UserIdentity
    {
        public static string Id { get; set; } = string.Empty;

        public static string UserName { get; set; } = string.Empty;

        public static string Password { get; set; } = string.Empty;

        public static string Name { get; set; } = string.Empty;

        public static string Avatar { get; set; } = string.Empty;

        public static EGender? Gender { get; set; }

        public static DateTimeOffset? DOB { get; set; }

        public static string PhoneNumber { get; set; } = string.Empty;

        public static EUserStatus Status { get; set; }

        public static DateTimeOffset CreatedDate { get; set; }

        public static DateTimeOffset? UpdatedDate { get; set; }

        public static void Set(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Name = user.FullName;
            Avatar = user.Avatar;
            Gender = user.Gender;
            DOB = user.DOB;
            PhoneNumber = user.PhoneNumber;
            Status = user.Status;
            CreatedDate = user.CreatedDate;
            UpdatedDate = user.UpdatedDate;
        }
    }
}
