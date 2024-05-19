using MilkTeaManagement.Application.Common.Interfaces;

namespace MilkTeaManagement.Infrastructure.Configurations
{
    public class EmailSettings : IEmailSettings
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Host { get; set; }

        public string DisplayName { get; set; }

        public int Port { get; set; }
    }
}
