namespace MilkTeaManagement.Domain.Common.Interfaces
{
    public class EntityAuditBase<T> : EntityBase<T>, IAuditable
    {
        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
