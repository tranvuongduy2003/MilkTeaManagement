using Microsoft.EntityFrameworkCore;

namespace MilkTeaManagement.Application.Common.SeedWork
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        Task<int> CommitAsync();
    }
}
