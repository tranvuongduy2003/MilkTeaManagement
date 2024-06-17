using Microsoft.AspNetCore.Identity;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    public partial class InformationPanel : UserControl
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public InformationPanel(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async void OnLoad(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var role = await _userManager.GetRolesAsync(user);

                this.role.Text = role.FirstOrDefault();
                this.fullName.Text = user.FullName;
                this.email.Text = user.Email;
                this.phoneNumber.Text = user.PhoneNumber;
                this.dob.Text = DateTime.Parse(user.DOB.ToString()).ToString("dd/MM/yyyy");
                this.gender.Text = user.Gender.ToString();
                this.status.Text = user.Status.ToString();
            }
        }
    }
}
