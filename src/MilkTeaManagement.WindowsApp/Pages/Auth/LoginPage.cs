using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Models.Auth;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.ValueObjetcs;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class LoginPage : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly UserManager<User> _userManager;

        public LoginPage(IAuthRepository authRepository, UserManager<User> userManager)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _userManager = userManager;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openRegisterPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage registerForm = Program.ServiceProvider.GetRequiredService<RegisterPage>();
            registerForm.Show();
        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;

            var payload = new LoginRequest
            {
                UserName = userName,
                Password = password,
            };

            var errorMessage = await _authRepository.LoginAsync(payload);

            if (!errorMessage.IsNullOrEmpty())
            {
                //TODO: Notify error
                MessageBox.Show(errorMessage);
                return;
            }
            else
            {
                var user = await _userManager.FindByNameAsync(userName);

                UserIdentity.Set(user);

                //TODO: Notify login successfully -> Hidden Login form -> Show Main form
                MessageBox.Show("Login successfully!");
                this.Hide();
                Main main = new Main();
                main.Show();
                return;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPasswordPage resetPasswordPage = Program.ServiceProvider.GetRequiredService<ResetPasswordPage>();
            resetPasswordPage.Show();
        }
    }
}
