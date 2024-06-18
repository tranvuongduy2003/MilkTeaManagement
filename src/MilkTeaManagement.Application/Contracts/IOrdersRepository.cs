using MilkTeaManagement.Application.Common.Models.Orders;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IOrdersRepository : IRepositoryBase<Order, string>
    {
        Task<Order> CheckoutAsync(CheckoutRequest request);
    }
}
