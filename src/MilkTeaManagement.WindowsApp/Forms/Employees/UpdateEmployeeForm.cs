using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.WindowsApp.Forms.Employees
{
    public partial class UpdateEmployeeForm : Form
    {
        private readonly IAzureBlobService _azureBlobService;
        private readonly UserManager<User> _userManager;

        private User Employee { get; set; }
        private string AvatarFilePath { get; set; } = string.Empty;

        public UpdateEmployeeForm(IAzureBlobService azureBlobService, UserManager<User> userManager)
        {
            InitializeComponent();
            _azureBlobService = azureBlobService;
            _userManager = userManager;
        }

        public async void OnLoadEmployee(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var roles = await _userManager.GetRolesAsync(user);

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
            Avatar.ImageLocation = user.Avatar;
            FullNameTextbox.Text = user.FullName;
            UserNameTextbox.Text = user.UserName;
            EmailTextbox.Text = user.Email;
            PhoneNumberTextbox.Text = user.PhoneNumber;
            GenderComboBox.SelectedText = user.Gender.GetDisplayName();
            DOBDateTimePicker.Value = DateTime.Parse(user.DOB.ToString());
            RoleComboBox.SelectedText = roles.FirstOrDefault();
            StatusComboBox.SelectedText = user.Status.GetDisplayName();

            Employee = user;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Avatar.Image = Properties.Resources.upload_image1;
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

        private async void Update_Click(object sender, EventArgs e)
        {
            try
            {
                var fullName = FullNameTextbox.Text;
                var userName = UserNameTextbox.Text;
                var email = EmailTextbox.Text;
                var phoneNumber = PhoneNumberTextbox.Text;
                var dob = DOBDateTimePicker.Value;
                var gender = GenderComboBox.Text;
                var role = RoleComboBox.Text;
                var status = StatusComboBox.Text;

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

                MessageBox.Show("Update employee successfully!", "Success!", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Employee == null)
                    throw new Exception("Employee is not existed");

                await _userManager.DeleteAsync(Employee);

                MessageBox.Show("Delete employee successfully!", "Success!", MessageBoxButtons.OK);
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
