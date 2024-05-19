using MilkTeaManagement.Domain.Common.Interfaces;

namespace MilkTeaManagement.Domain.Common
{
    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        public TKey Id { get; set; }
    }
}
