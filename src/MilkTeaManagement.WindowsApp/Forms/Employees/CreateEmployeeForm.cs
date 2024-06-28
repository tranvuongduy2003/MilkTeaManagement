using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.WindowsApp.Forms.Employees
{
    public partial class CreateEmployeeForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly UserManager<User> _userManager;

        private string AvatarFilePath { get; set; } = string.Empty;

        public CreateEmployeeForm(IAzureBlobService azureBlobService, UserManager<User> userManager)
        {
            InitializeComponent();
            _azureBlobService = azureBlobService;
            _userManager = userManager;

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Avatar.BackgroundImage = Properties.Resources.upload_image1;
            AvatarFilePath = string.Empty;
            FullNameTextbox.Clear();
            UserNameTextbox.Clear();
            EmailTextbox.Clear();
            PhoneNumberTextbox.Clear();
            this.Close();
        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Avatar.ImageLocation = openFileDialog.FileName;
                AvatarFilePath = openFileDialog.FileName;
            }
        }

        private async void create_Click(object sender, EventArgs e)
        {
            try
            {
                var fullName = FullNameTextbox.Text;
                var userName = UserNameTextbox.Text;
                var email = EmailTextbox.Text;
                var phoneNumber = PhoneNumberTextbox.Text;
                var dob = DOBDateTimePicker.Value;
                var gender = GenderComboBox.SelectedText;
                var role = RoleComboBox.SelectedText;
                var status = StatusComboBox.SelectedText;

                string error = "";

                if (AvatarFilePath.IsNullOrEmpty())
                    error += "**Avatar is required\n\n";
                if (fullName.IsNullOrEmpty())
                    error += "**FullName is required\n\n";
                if (userName.IsNullOrEmpty())
                    error += "**UserName is required\n\n";
                if (email.IsNullOrEmpty())
                    error += "**Email is required\n\n";
                if (phoneNumber.IsNullOrEmpty())
                    error += "**PhoneNumber is required\n\n";
                if (gender.IsNullOrEmpty())
                    error += "**Gender is required\n\n";
                if (role.IsNullOrEmpty())
                    error += "**Role is required\n\n";
                if (status.IsNullOrEmpty())
                    error += "**Status is required";

                if (!error.IsNullOrEmpty())
                {
                    throw new Exception(error);
                }

                var uploadedFile = await _azureBlobService.UploadAsync(AvatarFilePath);
                var user = new User
                {
                    Id = Program.UserIdentity.Id,
                    FullName = fullName,
                    Avatar = uploadedFile.Blob.Uri,
                    UserName = userName,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    Gender = Enum.Parse<EGender>(gender),
                    Status = Enum.Parse<EUserStatus>(status)
                };
                await _userManager.CreateAsync(user, "User@123");
                await _userManager.AddToRoleAsync(user, role);

                MessageBox.Show("Create new employee successfully!", "Success!", MessageBoxButtons.OK);

                Avatar.BackgroundImage = Properties.Resources.upload_image1;
                AvatarFilePath = string.Empty;
                FullNameTextbox.Clear();
                UserNameTextbox.Clear();
                EmailTextbox.Clear();
                PhoneNumberTextbox.Clear();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
