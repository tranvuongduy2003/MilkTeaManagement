namespace MilkTeaManagement.Application.Common.Models.Auth
{
    public class RegisterRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string AvatarFilePath { get; set; }

        public string FullName { get; set; }

        public string Role { get; set; }
    }
}
