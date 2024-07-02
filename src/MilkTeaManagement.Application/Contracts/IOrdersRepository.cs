using MilkTeaManagement.Application.Common.Models.Dashboard;
using MilkTeaManagement.Application.Common.Models.Orders;
using MilkTeaManagement.Application.Common.Models.Payments;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IOrdersRepository : IRepositoryBase<Order, string>
    {
        Task<Order> CheckoutAsync(CheckoutRequest request);

        Task<List<OrderDto>> GetOrdersByFilterAsync(string? search);

        Task<List<OrderItem>> GetOrderItemsByOrderIdAsync(string orderId);

        Task<List<OrderItem>> GetAllOrderItems();

        Task<List<OrderDto>> GetOrdersByEmployeeIdAsync(string id, string? search);

        Task<List<OrderDBDTO>> GetAllOrders();
    }
}
