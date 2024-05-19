using MilkTeaManagement.Application.Common.Models.Systems;

namespace MilkTeaManagement.Application.Common.Interfaces
{
    public interface IEmailService
    {
        Task SendMail(MailContent mailContent);

        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}
