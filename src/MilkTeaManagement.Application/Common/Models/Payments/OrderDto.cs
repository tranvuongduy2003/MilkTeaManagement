namespace MilkTeaManagement.Application.Common.Models.Payments
{
    public class OrderDto
    {
        public string Id { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal? Discount { get; set; }

        public float? Tax { get; set; }

        public string? CustomerPhone { get; set; }

        public string EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
