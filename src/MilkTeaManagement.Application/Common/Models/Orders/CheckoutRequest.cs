using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Common.Models.Orders
{
    public class CheckoutRequest
    {
        public decimal TotalPrice { get; set; }

        public float? Discount { get; set; }

        public float? Tax { get; set; }

        public string? CustomerPhone { get; set; }

        public string EmployeeId { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
