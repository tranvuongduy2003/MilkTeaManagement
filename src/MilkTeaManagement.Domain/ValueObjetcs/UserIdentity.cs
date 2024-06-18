using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Domain.ValueObjetcs
{
    public class UserIdentity : User
    {
        public string Role { get; set; }

        public void Set(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            FullName = user.FullName;
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
