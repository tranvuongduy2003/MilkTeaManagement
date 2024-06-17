using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.UserControls.Employees;

namespace MilkTeaManagement.WindowsApp.Pages.Employees
{
    public partial class EmployeesPage : UserControl
    {
        private readonly UserManager<User> _userManager;

        public EmployeesPage(UserManager<User> userManager)
        {
            InitializeComponent();
            _userManager = userManager;

            EmployeesTable.CellDoubleClick += OnLoadEmployeeInformation;
        }

        public async void OnLoad()
        {
            var employees = await _userManager.Users.ToListAsync();
            await LoadEmployeesList(employees);
        }

        private async Task LoadEmployeesList(List<User> employees)
        {
            EmployeesTable.Rows.Clear();
            if (employees.Count > 0)
            {
                EmployeesTable.Rows.Add(employees.Count);
                for (int index = 0; index < employees.Count; index++)
                {
                    var employee = employees[index];
                    var roles = await _userManager.GetRolesAsync(employee);
                    EmployeesTable.Rows[index].Cells["Id"].Value = employee.Id;
                    EmployeesTable.Rows[index].Cells["UserName"].Value = employee.UserName;
                    EmployeesTable.Rows[index].Cells["FullName"].Value = employee.FullName;
                    EmployeesTable.Rows[index].Cells["Email"].Value = employee.Email;
                    EmployeesTable.Rows[index].Cells["PhoneNumber"].Value = employee.PhoneNumber;
                    EmployeesTable.Rows[index].Cells["Gender"].Value = employee.Gender;
                    EmployeesTable.Rows[index].Cells["DOB"].Value = employee.DOB;
                    EmployeesTable.Rows[index].Cells["Status"].Value = employee.Status;
                    EmployeesTable.Rows[index].Cells["Role"].Value = roles.FirstOrDefault();
                }
            }
        }

        private async void OnLoadEmployeeInformation(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                InformationPanel infoPanel = Program.ServiceProvider.GetRequiredService<InformationPanel>();
                var selectedRow = EmployeesTable.Rows[e.RowIndex];
                var id = selectedRow.Cells["Id"].Value.ToString();

                infoPanel.Margin = new Padding(0);
                infoPanel.Location = new Point(0, 0);
                informationPanel.Controls.Add(infoPanel);
                infoPanel.OnLoad(id);
            }
        }
    }
}