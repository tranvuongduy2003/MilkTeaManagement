using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;
using MilkTeaManagement.WindowsApp.UserControls.Employees;

namespace MilkTeaManagement.WindowsApp.Forms.Employees
{
    public partial class DetailEmployeeForm : Form
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IAzureBlobService _azureBlobService;

        public User Employee { get; set; }
        public string Search { get; set; } = string.Empty;
        private string AvatarFilePath { get; set; } = string.Empty;

        public DetailEmployeeForm(UserManager<User> userManager, IOrdersRepository ordersRepository, IAzureBlobService azureBlobService)
        {
            InitializeComponent();
            _userManager = userManager;
            _ordersRepository = ordersRepository;
            _azureBlobService = azureBlobService;

            Avatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public async Task OnLoad(string id)
        {
            var employee = await _userManager.FindByIdAsync(id);
            var roles = await _userManager.GetRolesAsync(employee);
            var employeeRole = roles.FirstOrDefault();

            Employee = employee;
            AvatarFilePath = employee.Avatar;
            Avatar.ImageLocation = employee.Avatar;
            role.Text = employeeRole;
            fullName.Text = employee.FullName;
            FullNameTextbox.Text = employee.FullName;
            UserNameTextbox.Text = employee.UserName;
            EmailTextbox.Text = employee.Email;
            PhoneNumberTextbox.Text = employee.PhoneNumber;
            GenderComboBox.Text = employee.Gender.GetDisplayName();
            DOBDateTimePicker.Value = DateTime.Parse(employee.DOB.ToString());
            RoleComboBox.Text = employeeRole;
            StatusComboBox.Text = employee.Status.GetDisplayName();
            SalaryTextBox.Text = employee.HourlySalary.ToString();

            LoadCheckoutHistory(employee);
        }

        private void LoadCheckoutHistory(User? employee)
        {
            ContentPanel.Controls.Clear();
            CheckoutHistory checkoutHistory = Program.ServiceProvider.GetRequiredService<CheckoutHistory>();
            checkoutHistory.OnLoad(employee);
            ContentPanel.Controls.Add(checkoutHistory);
        }

        private void LoadWorkDays(User? employee)
        {
            ContentPanel.Controls.Clear();
            WorkDays workDays = Program.ServiceProvider.GetRequiredService<WorkDays>();
            workDays.OnLoad(employee);
            ContentPanel.Controls.Add(workDays);
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
                var user = await _userManager.FindByIdAsync(Employee.Id);

                user.FullName = fullName;
                user.Avatar = uploadedFile.Blob.Uri;
                user.UserName = userName;
                user.Email = email;
                user.PhoneNumber = phoneNumber;
                user.Gender = Enum.Parse<EGender>(gender);
                user.Status = Enum.Parse<EUserStatus>(status);

                await _userManager.UpdateAsync(user);
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Avatar.Image = Properties.Resources.upload_image1;
            AvatarFilePath = string.Empty;
            FullNameTextbox.Clear();
            UserNameTextbox.Clear();
            EmailTextbox.Clear();
            PhoneNumberTextbox.Clear();
            this.DialogResult = DialogResult.OK;
        }

        private void CheckoutHistoryButton_Click(object sender, EventArgs e) => LoadCheckoutHistory(Employee);

        private void WorkDayButton_Click(object sender, EventArgs e) => LoadWorkDays(Employee);

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
