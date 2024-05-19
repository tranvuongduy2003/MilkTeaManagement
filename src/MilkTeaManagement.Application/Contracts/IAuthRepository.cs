using MilkTeaManagement.Application.Common.Models.Auth;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IAuthRepository
    {

        Task<string> LoginAsync(LoginRequest request);

        Task<string> RegisterAsync(RegisterRequest request);

        Task<string> ResetPasswordAsync(string email);
    }
}
