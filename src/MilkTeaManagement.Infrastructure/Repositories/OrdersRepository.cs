using Infrastructure.Common;
using MilkTeaManagement.Application.Common.Models.Orders;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class OrdersRepository : RepositoryBase<Order, string, ApplicationDbContext>, IOrdersRepository
    {
        public OrdersRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<Order> CheckoutAsync(CheckoutRequest request)
        {
            try
            {
                var order = new Order
                {
                    CustomerPhone = request.CustomerPhone,
                    Discount = request.Discount,
                    EmployeeId = request.EmployeeId,
                    Tax = request.Tax,
                    TotalPrice = request.TotalPrice,
                };
                await CreateAsync(order);
                await SaveChangesAsync();

                foreach (var item in request.OrderItems)
                {
                    var orderItem = new OrderItem
                    {
                        OrderId = order.Id,
                        Description = item.Description,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        SubTotalPrice = item.SubTotalPrice,
                    };

                    await _dbContext.OrderItems.AddAsync(orderItem);
                }
                await _dbContext.SaveChangesAsync();

                return order;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
