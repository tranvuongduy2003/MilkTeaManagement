using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<User> _userManager;

        public AuthRepository(ApplicationDbContext context, IEmailService emailService, UserManager<User> userManager)
        {
            _context = context;
            _emailService = emailService;
            _userManager = userManager;
        }

        public async Task<string> LoginAsync(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null)
                return "User does not exist";

            bool isValidPassword = await _userManager.CheckPasswordAsync(user, request.Password);
            if (!isValidPassword)
                return "Wrong password";

            return "";
        }

        public async Task<string> RegisterAsync(RegisterRequest request)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.UserName.Equals(request.UserName) || u.Email.Equals(request.Email));
            if (user != null)
                return "User name or Email already existed";

            user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.UserName,
                Email = request.Email,
                Avatar = request.AvatarFilePath,
                FullName = request.FullName,
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                var userToReturn = await _userManager.FindByNameAsync(request.UserName);
                await _userManager.AddToRoleAsync(user, request.Role);
                await SendRegistrationConfirmationEmailAsync(user.Email, user.UserName);

                return "Register successfully!";
            }

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

            await _userManager.ChangePasswordAsync(user, user.PasswordHash, hashedPassword);

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
