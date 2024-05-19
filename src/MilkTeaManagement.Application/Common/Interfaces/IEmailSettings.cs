namespace MilkTeaManagement.Application.Common.Interfaces
{
    public interface IEmailSettings
    {
        string Email { get; set; }

        string Password { get; set; }

        string Host { get; set; }

        string DisplayName { get; set; }

        int Port { get; set; }
    }
}
