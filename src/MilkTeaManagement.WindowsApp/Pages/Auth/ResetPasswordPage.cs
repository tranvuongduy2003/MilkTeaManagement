using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Contracts;
using System.Runtime.InteropServices;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class ResetPasswordPage : Form
    {
        private readonly IAuthRepository _authRepository;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public ResetPasswordPage(IAuthRepository authRepository)
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

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
            var email = emailTextBox.Text;

            await _authRepository.ResetPasswordAsync(email);

            MessageBox.Show("The new password was sent to your email!");
            return;
        }
    }
}
