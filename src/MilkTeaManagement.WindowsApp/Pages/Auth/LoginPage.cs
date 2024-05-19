using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Contracts;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    public partial class LoginPage : Form
    {
        private readonly IAuthRepository _authRepository;
        private readonly IUsersRepository _usersRepository;

        public LoginPage(IAuthRepository authRepository, IUsersRepository usersRepository)
        {
            InitializeComponent();
            _authRepository = authRepository;
            _usersRepository = usersRepository;
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            //var userName = userNameTextBox.Text;
            //var password = passwordTextBox.Text;

            //var payload = new LoginRequest
            //{
            //    UserName = userName,
            //    Password = password,
            //};

            //var errorMessage = _authRepository.Login(payload);

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
            //    MessageBox.Show("Login successfully!");
            //    this.Hide();
            //    MainForm mainForm = new MainForm();
            //    mainForm.Show();
            //    return;
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResetPasswordPage resetPasswordPage = Program.ServiceProvider.GetRequiredService<ResetPasswordPage>();
            resetPasswordPage.Show();
        }
    }
}
