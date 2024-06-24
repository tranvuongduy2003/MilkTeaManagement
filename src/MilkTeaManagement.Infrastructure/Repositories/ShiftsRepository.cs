using Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Data;

namespace MilkTeaManagement.Infrastructure.Repositories
{
    public class ShiftsRepository : RepositoryBase<Shift, string, ApplicationDbContext>, IShiftsRepository
    {
        public ShiftsRepository(ApplicationDbContext dbContext, IUnitOfWork<ApplicationDbContext> unitOfWork) : base(dbContext, unitOfWork)
        {
        }

        public async Task<List<Shift>> GetShiftsByEmployeeIdAsync(string employeeId)
        {
            try
            {
                var employee = await _dbContext.Users.FindAsync(employeeId);
                if (employee == null)
                    throw new Exception("Employee does not exist!");

                var shifts = await _dbContext.Shifts
                    .AsNoTracking()
                    .Where(shift => shift.EmployeeId == employee.Id)
                    .OrderBy(shift => shift.Time)
                    .ToListAsync();

                return shifts;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
