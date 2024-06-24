using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Forms.Employees;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.Pages.Employees
{
    public partial class EmployeesPage : Page
    {
        private readonly UserManager<User> _userManager;

        public EmployeesPage(UserManager<User> userManager)
        {
            InitializeComponent();
            _userManager = userManager;

            EmployeesTable.CellDoubleClick += OnLoadEmployeeInformation;
        }

        public override async void OnLoad()
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
                    EmployeesTable.Rows[index].Cells["Salary"].Value = $"{ConvertCurrency.ToVND((decimal)employee.HourlySalary)}/h";
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
                var selectedCell = EmployeesTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = EmployeesTable.Rows[selectedCell.RowIndex];
                    var id = selectedRow.Cells["Id"].Value.ToString();
                    DetailEmployeeForm detailEmployeeForm = Program.ServiceProvider.GetService<DetailEmployeeForm>();
                    detailEmployeeForm.OnLoad(id);
                    detailEmployeeForm.ShowDialog();
                }
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateEmployeeForm createEmployeeForm = Program.ServiceProvider.GetRequiredService<CreateEmployeeForm>();

            if (createEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                this.OnLoad();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (EmployeesTable.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select employee row to update!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedCell = EmployeesTable.SelectedCells[0];
            if (selectedCell.RowIndex >= 0)
            {
                DetailEmployeeForm detailEmployeeForm = Program.ServiceProvider.GetRequiredService<DetailEmployeeForm>();
                var selectedRow = EmployeesTable.Rows[selectedCell.RowIndex];
                var id = selectedRow.Cells["Id"].Value.ToString();
                detailEmployeeForm.OnLoad(id);
                if (detailEmployeeForm.ShowDialog() == DialogResult.OK)
                {
                    this.OnLoad();
                }
            }
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeesTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select employee row to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCell = EmployeesTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = EmployeesTable.Rows[selectedCell.RowIndex];

                    var employee = await _userManager.FindByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                    if (employee == null)
                        throw new Exception("Employee is not existed");

                    await _userManager.DeleteAsync(employee);

                    MessageBox.Show("Delete employee successfully!", "Success!", MessageBoxButtons.OK);
                    this.OnLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}