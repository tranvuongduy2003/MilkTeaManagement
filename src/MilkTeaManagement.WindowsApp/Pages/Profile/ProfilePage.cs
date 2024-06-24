using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.Pages.Profile
{
    public partial class ProfilePage : Page
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly UserManager<User> _userManager;

        public string AvatarFilePath { get; set; }

        public ProfilePage(IAzureBlobService azureBlobService, UserManager<User> userManager)
        {
            InitializeComponent();
            _azureBlobService = azureBlobService;
            _userManager = userManager;
        }

        public override async void OnLoad()
        {
            var user = await _userManager.FindByIdAsync(Program.UserIdentity.Id);
            var roles = await _userManager.GetRolesAsync(user);

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            Avatar.ImageLocation = user.Avatar;
            FullNameTextbox.Text = user.FullName;
            UserNameTextbox.Text = user.UserName;
            EmailTextbox.Text = user.Email;
            PhoneNumberTextbox.Text = user.PhoneNumber;
            GenderComboBox.SelectedText = user.Gender.GetDisplayName();
            DOBDateTimePicker.Value = DateTime.Parse(user.DOB.ToString());
            RoleTextbox.SelectedText = roles.FirstOrDefault();
            StatusTextbox.SelectedText = user.Status.GetDisplayName();
        }

        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var fullName = FullNameTextbox.Text;
                var userName = UserNameTextbox.Text;
                var email = EmailTextbox.Text;
                var phoneNumber = PhoneNumberTextbox.Text;
                var gender = GenderComboBox.SelectedText;
                var dob = DOBDateTimePicker.Value;
                var role = RoleTextbox.Text;
                var status = StatusTextbox.Text;

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
                await _userManager.UpdateAsync(user);

                MessageBox.Show("Update profile successfully!", "Success!", MessageBoxButtons.OK);

                Program.UserIdentity.Set(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
    }
}
