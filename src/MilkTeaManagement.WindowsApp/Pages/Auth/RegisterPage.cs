using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Auth;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using System.Runtime.InteropServices;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class RegisterPage : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly UserManager<User> _userManager;
        private readonly IAzureBlobService _azureBlobService;

        private string AvatarFileName { get; set; } = string.Empty;

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

        public RegisterPage(IAuthRepository authRepository, UserManager<User> userManager, IAzureBlobService azureBlobService)
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            _authRepository = authRepository;
            _userManager = userManager;
            _azureBlobService = azureBlobService;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openLoginPageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginForm = Program.ServiceProvider.GetRequiredService<LoginPage>();
            loginForm.Show();
        }

        private async void registerButton_ClickAsync(object sender, EventArgs e)
        {
            var fullName = fullNameTextBox.Text;
            var userName = userNameTextBox.Text;
            var email = emailTextBox.Text;
            var phoneNumber = phoneNumberTextBox.Text;
            var password = passwordTextBox.Text;
            var confirmPassword = confirmPasswordTextBox.Text;
            var role = roleComboBox.Text;

            string error = "";

            if (fullName.IsNullOrEmpty())
                error += "**Full name is required\n\n";
            if (userName.IsNullOrEmpty())
                error += "**User name is required\n\n";
            if (email.IsNullOrEmpty())
                error += "**Email is required\n\n";
            if (phoneNumber.IsNullOrEmpty())
                error += "**Phone Number is required\n\n";
            if (password.IsNullOrEmpty())
                error += "**Password is required\n\n";
            if (confirmPassword.IsNullOrEmpty())
                error += "**Confirm password is required\n\n";
            if (AvatarFileName.IsNullOrEmpty())
                error += "**Avatar is required\n\n";
            if (confirmPassword != password)
                error += "**Confirm password does not match with password!\n\n";
            if (role.IsNullOrEmpty())
                error += "**Role is required\n\n";

            if (!error.IsNullOrEmpty())
            {
                MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var uploadedFile = await _azureBlobService.UploadAsync(AvatarFileName);
            var payload = new RegisterRequest
            {
                UserName = userName,
                Password = password,
                Email = email,
                PhoneNumber = phoneNumber,
                AvatarFilePath = uploadedFile.Blob.Uri,
                FullName = fullName,
                Role = role,
            };

            var errorMessage = await _authRepository.RegisterAsync(payload);

            if (!errorMessage.IsNullOrEmpty())
            {
                //TODO: Notify error
                MessageBox.Show(errorMessage);
                return;
            }
            else
            {
                var user = await _userManager.FindByNameAsync(payload.UserName);
                var roles = await _userManager.GetRolesAsync(user);

                Program.UserIdentity.Set(user);
                Program.UserIdentity.Role = roles.FirstOrDefault();

                //TODO: Notify login successfully -> Hidden Login form -> Show Main form
                MessageBox.Show("Register successfully!");
                this.Hide();
                Main main = new Main();
                main.Show();
                return;
            }
        }

        private void avatarUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatarUpload.BackgroundImage = new Bitmap(openFileDialog.FileName);
                AvatarFileName = openFileDialog.FileName;
            }
        }
    }
}
