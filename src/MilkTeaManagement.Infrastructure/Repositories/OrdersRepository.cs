﻿using Infrastructure.Common;
using MailKit.Search;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MilkTeaManagement.Application.Common.Models.Dashboard;
using MilkTeaManagement.Application.Common.Models.Orders;
using MilkTeaManagement.Application.Common.Models.Payments;
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

        public async Task<List<OrderItem>> GetAllOrderItems()
        {
            var orderItems = await _dbContext.OrderItems
                .AsNoTracking()
                .Include(orderItem => orderItem.Product)
                .ToListAsync();

            return orderItems;
        }

        public async Task<List<OrderDBDTO>> GetAllOrders()
        {
            try
            {
                var orders = await _dbContext.Orders
                    .AsNoTracking()
                    .Select(o => new OrderDBDTO
                    {
                        Id = o.Id,
                        TotalPrice = o.TotalPrice,
                        CreatedDate = o.CreatedDate.DateTime
                    })
                    .ToListAsync();

                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<OrderItem>> GetOrderItemsByOrderIdAsync(string orderId)
        {
            var orderItems = await _dbContext.OrderItems
                .AsNoTracking()
                .Where(orderItem => orderItem.OrderId == orderId)
                .Include(orderItem => orderItem.Product)
                .ToListAsync();

            return orderItems;
        }
        
        public async Task<List<OrderDto>> GetOrdersByEmployeeIdAsync(string id, string? search)
        {
            try
            {
                var employee = await _dbContext.Users.FindAsync(id);
                if (employee == null)
                    throw new Exception("Employee does not exist!");

                var orders = await _dbContext.Orders
                    .AsNoTracking()
                    .Where(order =>
                        (order.EmployeeId == employee.Id) &&
                        (search.IsNullOrEmpty()
                        ? true
                        : order.CustomerPhone.Contains(search)))
                    .OrderByDescending(order => order.CreatedDate)
                    .Select((order) => new OrderDto
                    {
                        Id = order.Id,
                        CustomerPhone = order.CustomerPhone,
                        Discount = order.Discount == null || order.Discount == 0.0 ? (decimal)0.0 : (order.TotalPrice / (decimal)order.Discount),
                        Tax = order.Tax,
                        EmployeeId = order.EmployeeId,
                        EmployeeName = employee.FullName,
                        TotalPrice = order.TotalPrice,
                        UpdatedDate = order.UpdatedDate,
                        CreatedDate = order.CreatedDate,
                    })
                    .ToListAsync();

                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<OrderDto>> GetOrdersByFilterAsync(string? search)
        {
            try
            {
                var orders = await _dbContext.Orders
                    .AsNoTracking()
                    .Join(
                        _dbContext.Users.AsNoTracking(),
                        order => order.EmployeeId,
                        user => user.Id,
                        (order, user) => new OrderDto
                        {
                            Id = order.Id,
                            CustomerPhone = order.CustomerPhone,
                            Discount = order.Discount == null || order.Discount == 0.0 ? (decimal)0.0 : (order.TotalPrice / (decimal)order.Discount),
                            Tax = order.Tax,
                            EmployeeId = order.EmployeeId,
                            EmployeeName = user.FullName,
                            TotalPrice = order.TotalPrice,
                            UpdatedDate = order.UpdatedDate,
                            CreatedDate = order.CreatedDate,
                        })
                    .Where(order =>
                        search.IsNullOrEmpty()
                        ? true
                        : (order.CustomerPhone.Contains(search) || order.EmployeeName.Contains(search)))
                    .OrderByDescending(order => order.CreatedDate)
                    .ToListAsync();

                return orders;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
