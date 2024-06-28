using Microsoft.OpenApi.Extensions;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    public partial class WorkDays : UserControl
    {
        private readonly IShiftsRepository _shiftsRepository;

        public User Employee { get; set; }

        public WorkDays(IShiftsRepository shiftsRepository)
        {
            InitializeComponent();

            _shiftsRepository = shiftsRepository;
        }

        public async void OnLoad(User employee)
        {
            Employee = employee;
            var shifts = await _shiftsRepository.GetShiftsByEmployeeIdAsync(employee.Id);

            WorkDaysDataGridView.Rows.Clear();
            foreach (var shift in shifts)
            {
                WorkDaysDataGridView.Rows.Add(
                    shift.Id,
                    shift.Time.GetDisplayName(),
                    shift.Mo,
                    shift.Tu,
                    shift.We,
                    shift.Th,
                    shift.Fr,
                    shift.Sa,
                    shift.Su);
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in WorkDaysDataGridView.Rows)
                {
                    var shift = new Shift
                    {
                        Id = row.Cells[0].Value.ToString(),
                        EmployeeId = Employee.Id,
                        Time = Enum.Parse<EDayTime>(row.Cells[1].Value.ToString()),
                        Mo = Convert.ToBoolean(row.Cells[2].Value),
                        Tu = Convert.ToBoolean(row.Cells[3].Value),
                        We = Convert.ToBoolean(row.Cells[4].Value),
                        Th = Convert.ToBoolean(row.Cells[5].Value),
                        Sa = Convert.ToBoolean(row.Cells[7].Value),
                        Su = Convert.ToBoolean(row.Cells[8].Value),
                    };

                    await _shiftsRepository.UpdateAsync(shift);
                }

                await _shiftsRepository.SaveChangesAsync();

                MessageBox.Show("Save successfully!", "Success!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
