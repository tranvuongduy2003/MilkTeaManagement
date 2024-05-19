using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Contracts;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class ResetPasswordPage : Form
    {
        private readonly IAuthRepository _authRepository;

        public ResetPasswordPage(IAuthRepository authRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginForm = Program.ServiceProvider.GetRequiredService<LoginPage>();
            loginForm.Show();
        }

        private async void resetPasswordButton_ClickAsync(object sender, EventArgs e)
        {
            //var email = emailTextBox.Text;

            //await _authRepository.ResetPasswordAsync(email);

            //MessageBox.Show("The new password was sent to your email!");
            //return;
        }
    }
}
