using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Contracts;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class RegisterPage : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUsersRepository _usersRepository;

        private string AvatarFileName { get; set; } = string.Empty;

        public RegisterPage(IAuthRepository authRepository, IUsersRepository usersRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _usersRepository = usersRepository;
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
            //var fullName = fullNameTextBox.Text;
            //var userName = userNameTextBox.Text;
            //var email = emailTextBox.Text;
            //var password = passwordTextBox.Text;
            //var confirmPassword = confirmPasswordTextBox.Text;

            //string error = "";

            //if (fullName.IsNullOrEmpty())
            //    error += "**Full name is required\n\n";
            //if (userName.IsNullOrEmpty())
            //    error += "**User name is required\n\n";
            //if (email.IsNullOrEmpty())
            //    error += "**Email is required\n\n";
            //if (password.IsNullOrEmpty())
            //    error += "**Password is required\n\n";
            //if (confirmPassword.IsNullOrEmpty())
            //    error += "**Confirm password is required\n\n";
            //if (AvatarFileName.IsNullOrEmpty())
            //    error += "**Avatar is required\n\n";
            //if (confirmPassword != password)
            //    error += "**Confirm password does not match with password!\n\n";

            //if (!error.IsNullOrEmpty())
            //{
            //    MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var payload = new RegisterRequest
            //{
            //    UserName = userName,
            //    Password = password,
            //    Email = email,
            //    AvatarFileName = AvatarFileName,
            //    FullName = fullName
            //};

            //var errorMessage = await _authRepository.RegisterAsync(payload);

            //if (!errorMessage.IsNullOrEmpty())
            //{
            //    //TODO: Notify error
            //    MessageBox.Show(errorMessage);
            //    return;
            //}
            //else
            //{
            //    var user = _usersRepository.GetByUserName(userName);

            //    UserIdentity.UserName = user.UserName;
            //    UserIdentity.Avatar = user.Avatar;
            //    UserIdentity.FullName = user.FullName;
            //    UserIdentity.Email = user.Email;
            //    UserIdentity.Id = user.Id;

            //    //TODO: Notify login successfully -> Hidden Login form -> Show Main form
            //    MessageBox.Show("Register successfully!");
            //    this.Hide();
            //    Main main = new Main();
            //    main.Show();
            //    return;
            //}
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
