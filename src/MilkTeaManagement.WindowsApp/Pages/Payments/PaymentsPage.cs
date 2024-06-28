using MilkTeaManagement.Application.Common.Models.Payments;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Forms.Payments;
using MilkTeaManagement.WindowsApp.Helpers;
using System.Data;

namespace MilkTeaManagement.WindowsApp.Pages.Payments
{
    public partial class PaymentsPage : UserControl
    {
        private readonly IOrdersRepository _ordersRepository;

        public string Search { get; set; } = string.Empty;

        public PaymentsPage(IOrdersRepository ordersRepository)
        {
            InitializeComponent();
            _ordersRepository = ordersRepository;
        }

        public async void OnLoad()
        {

            var orders = await _ordersRepository.GetOrdersByFilterAsync(null);
            await LoadOrdersList(orders);
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ((TextBox)sender).Text;
            Search = searchText;

            var orders = await _ordersRepository.GetOrdersByFilterAsync(Search);
            await LoadOrdersList(orders);
        }

        private async Task LoadOrdersList(List<OrderDto> orders)
        {
            PaymentsTable.Rows.Clear();
            if (orders.Count > 0)
            {
                PaymentsTable.Rows.Add(orders.Count);
                for (int index = 0; index < orders.Count; index++)
                {
                    var order = orders[index];
                    PaymentsTable.Rows[index].Cells["Id"].Value = order.Id;
                    PaymentsTable.Rows[index].Cells["TotalPrice"].Value = ConvertCurrency.ToVND(order.TotalPrice);
                    PaymentsTable.Rows[index].Cells["Discount"].Value = ConvertCurrency.ToVND(order.Discount ?? (decimal)0.0);
                    PaymentsTable.Rows[index].Cells["CustomerPhone"].Value = order.CustomerPhone;
                    PaymentsTable.Rows[index].Cells["EmployeeId"].Value = order.EmployeeId;
                    PaymentsTable.Rows[index].Cells["EmployeeName"].Value = order.EmployeeName;
                    PaymentsTable.Rows[index].Cells["CreatedAt"].Value = order.CreatedDate;
                }
            }
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaymentsTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select order row to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCell = PaymentsTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = PaymentsTable.Rows[selectedCell.RowIndex];

                    var order = await _ordersRepository.GetByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                    if (order == null)
                        throw new Exception("Order is not existed");

                    await _ordersRepository.DeleteAsync(order);
                    await _ordersRepository.SaveChangesAsync();

                    MessageBox.Show("Delete new order successfully!", "Success!", MessageBoxButtons.OK);
                    this.OnLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaymentsTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select an order to print!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCell = PaymentsTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = PaymentsTable.Rows[selectedCell.RowIndex];

                    var order = await _ordersRepository.GetByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                    if (order == null)
                        throw new Exception("Order is not existed");

                    var orderItems = await _ordersRepository.GetOrderItemsByOrderIdAsync(order.Id);

                    PrintBillForm printBillForm = new PrintBillForm(order, orderItems);
                    printBillForm.ShowDialog();
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
