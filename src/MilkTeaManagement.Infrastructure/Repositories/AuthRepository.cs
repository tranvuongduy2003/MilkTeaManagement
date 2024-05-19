using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Auth;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public AuthRepository(ApplicationDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task<string> LoginAsync(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);
            if (user == null)
                return "User does not exist";

            var isValidPassword = BCrypt.Net.BCrypt.Verify(request.Password, user.Password);

            if (!isValidPassword)
                return "Wrong password";

            return "Login successfully!";
        }

        public async Task<string> RegisterAsync(RegisterRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == request.UserName);
            if (user != null)
                return "User name already existed";

            user = await _context.Users.FirstOrDefaultAsync(user => user.Email == request.Email);
            if (user != null)
                return "Email already existed";

            user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email,
                Avatar = request.AvatarFilePath,
                FullName = request.FullName,
            };

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(request.Password);
            if (hashedPassword == null)
                return "Something went wrong!";

            user.Password = hashedPassword;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            await SendRegistrationConfirmationEmailAsync(user.Email, user.UserName);

            return "";
        }

        public async Task<string> ResetPasswordAsync(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == email);
            if (user == null)
                return "User does not exist";

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword("user@123");
            if (hashedPassword == null)
                return "Something went wrong!";

            user.Password = hashedPassword;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            await SendResetPasswordEmailAsync(user.Email, hashedPassword);

            return "";
        }

        private async Task SendRegistrationConfirmationEmailAsync(string email, string userName)
        {
            string FullPath = "D:\\.NET\\MilkTeaManagement\\src\\MilkTeaManagement.Application\\Templates\\SignUpEmailTemplate.html";

            StreamReader str = new StreamReader(FullPath);

            string mailText = str.ReadToEnd();

            str.Close();

            mailText = mailText.Replace("[userName]", userName);

            await _emailService.SendEmailAsync(email, "Registration Confirmation", mailText);
        }

        private async Task SendResetPasswordEmailAsync(string email, string newPassword)
        {
            string FullPath = "D:\\.NET\\MilkTeaManagement\\src\\MilkTeaManagement.Application\\Templates\\ResetPasswordEmailTemplate.html";

            StreamReader str = new StreamReader(FullPath);

            string mailText = str.ReadToEnd();

            str.Close();

            mailText = mailText.Replace("[newPassword]", newPassword);

            await _emailService.SendEmailAsync(email, "Reset Your Password", mailText);
        }
    }
}
