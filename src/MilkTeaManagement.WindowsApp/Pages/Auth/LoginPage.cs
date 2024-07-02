using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Models.Auth;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using System.Runtime.InteropServices;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class LoginPage : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly UserManager<User> _userManager;

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

        public LoginPage(IAuthRepository authRepository, UserManager<User> userManager)
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

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
                var roles = await _userManager.GetRolesAsync(user);

                Program.UserIdentity.Set(user);
                Program.UserIdentity.Role = roles.FirstOrDefault();

                //TODO: Notify login successfully -> Hidden Login form -> Show Main form
                MessageBox.Show("Login successfully!");
                this.Hide();

                // Clear username and password textbox
                userNameTextBox.Clear();
                passwordTextBox.Clear();

                Main main = new Main();
                main.Show();
                return;
            }
        }

        public void FocusUserNameTextBox()
        {
            userNameTextBox.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPasswordPage resetPasswordPage = Program.ServiceProvider.GetRequiredService<ResetPasswordPage>();
            resetPasswordPage.Show();
        }
    }
}
