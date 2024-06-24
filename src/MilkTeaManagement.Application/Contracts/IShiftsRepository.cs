using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Entities;

namespace MilkTeaManagement.Application.Contracts
{
    public interface IShiftsRepository : IRepositoryBase<Shift, string>
    {
        Task<List<Shift>> GetShiftsByEmployeeIdAsync(string employeeId);
    }
}
