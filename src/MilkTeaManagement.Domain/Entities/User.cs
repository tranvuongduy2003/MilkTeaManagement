using MilkTeaManagement.Domain.Common;

namespace MilkTeaManagement.Domain.Entities
{
    public class User : EntityBase<long>
    {
        public string UserName { get; set; }
    }
}
