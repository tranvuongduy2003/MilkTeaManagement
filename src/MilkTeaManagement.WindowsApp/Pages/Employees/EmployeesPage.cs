﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Forms.Employees;
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
                UpdateEmployeeForm updateEmployeeForm = Program.ServiceProvider.GetRequiredService<UpdateEmployeeForm>();
                var selectedRow = EmployeesTable.Rows[selectedCell.RowIndex];
                var id = selectedRow.Cells["Id"].Value.ToString();
                updateEmployeeForm.OnLoadEmployee(id);
                if (updateEmployeeForm.ShowDialog() == DialogResult.OK)
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