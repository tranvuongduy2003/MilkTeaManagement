using Microsoft.AspNetCore.Identity;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Models.Payments;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.WindowsApp.Helpers;

namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    public partial class CheckoutHistory : UserControl
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IAzureBlobService _azureBlobService;

        public User Employee { get; set; }
        public string Search { get; set; } = string.Empty;
        private string AvatarFilePath { get; set; } = string.Empty;

        public CheckoutHistory(UserManager<User> userManager, IOrdersRepository ordersRepository, IAzureBlobService azureBlobService)
        {
            InitializeComponent();
            _userManager = userManager;
            _ordersRepository = ordersRepository;
            _azureBlobService = azureBlobService;
        }

        public async void OnLoad(User employee)
        {
            Employee = employee;
            var orders = await _ordersRepository.GetOrdersByEmployeeIdAsync(Employee.Id, null);
            LoadOrdersList(orders);
        }

        private void LoadOrdersList(List<OrderDto> orders)
        {
            OrdersTable.Rows.Clear();
            if (orders.Count > 0)
            {
                OrdersTable.Rows.Add(orders.Count);
                for (int index = 0; index < orders.Count; index++)
                {
                    var order = orders[index];
                    OrdersTable.Rows[index].Cells["Id"].Value = order.Id;
                    OrdersTable.Rows[index].Cells["TotalPrice"].Value = ConvertCurrency.ToVND(order.TotalPrice);
                    OrdersTable.Rows[index].Cells["Discount"].Value = order.Discount != null && order.Discount > 0 ? ConvertCurrency.ToVND((decimal)order.Discount) : "0 VNĐ";
                    OrdersTable.Rows[index].Cells["CustomerPhone"].Value = order.CustomerPhone;
                    OrdersTable.Rows[index].Cells["EmployeeId"].Value = order.EmployeeId;
                    OrdersTable.Rows[index].Cells["CreatedAt"].Value = order.CreatedDate;
                }
            }
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrdersTable.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select order row to delete!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var selectedCell = OrdersTable.SelectedCells[0];
                if (selectedCell.RowIndex >= 0)
                {
                    var selectedRow = OrdersTable.Rows[selectedCell.RowIndex];

                    var order = await _ordersRepository.GetByIdAsync(selectedRow.Cells["Id"].Value.ToString());

                    if (order == null)
                        throw new Exception("Order is not existed");

                    await _ordersRepository.DeleteAsync(order);
                    await _ordersRepository.SaveChangesAsync();

                    MessageBox.Show("Delete new order successfully!", "Success!", MessageBoxButtons.OK);

                    var orders = await _ordersRepository.GetOrdersByEmployeeIdAsync(Employee.Id, null);
                    LoadOrdersList(orders);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            var searchText = ((TextBox)sender).Text;
            Search = searchText;

            var orders = await _ordersRepository.GetOrdersByEmployeeIdAsync(Employee.Id, Search);
            LoadOrdersList(orders);
        }
    }
}
