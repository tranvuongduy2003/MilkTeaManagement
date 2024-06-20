using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Domain.Common;
using MilkTeaManagement.Infrastructure.Common;

namespace Infrastructure.Common
{
    public class RepositoryBase<T, K, TContext> : RepositoryQueryBase<T, K, TContext>, IRepositoryBase<T, K, TContext> where T : EntityBase<K> where TContext : DbContext
    {
        protected readonly TContext _dbContext;
        protected readonly IUnitOfWork<TContext> _unitOfWork;

        public RepositoryBase(TContext dbContext, IUnitOfWork<TContext> unitOfWork) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }


        public Task<IDbContextTransaction> BeginTransactionAsync() => _dbContext.Database.BeginTransactionAsync();

        public async Task EndTransactionAsync()
        {
            await SaveChangesAsync();
            await _dbContext.Database.CommitTransactionAsync();
        }

        public Task RollbackTransactionAsync() => _dbContext.Database.RollbackTransactionAsync();

        public void Create(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Set<T>().Add(entity);
        }

        public async Task<K> CreateAsync(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id;
        }

        public IList<K> CreateList(IEnumerable<T> entities)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Set<T>().AddRange(entities);
            return entities.Select(x => x.Id).ToList();
        }

        public async Task<IList<K>> CreateListAsync(IEnumerable<T> entities)
        {
            _dbContext.ChangeTracker.Clear();
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
            return entities.Select(x => x.Id).ToList();
        }

        public void Update(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            if (_dbContext.Entry(entity).State == EntityState.Unchanged) return;

            T exist = _dbContext.Set<T>().Find(entity.Id);
            _dbContext.Entry(exist).CurrentValues.SetValues(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            if (_dbContext.Entry(entity).State == EntityState.Unchanged) return;

            T exist = _dbContext.Set<T>().Find(entity.Id);
            _dbContext.Entry(exist).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void UpdateList(IEnumerable<T> entities) => _dbContext.Set<T>().AddRange(entities);

        public async Task UpdateListAsync(IEnumerable<T> entities)
        {
            _dbContext.ChangeTracker.Clear();
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Set<T>().Remove(entity);
        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void DeleteList(IEnumerable<T> entities) => _dbContext.Set<T>().RemoveRange(entities);

        public async Task DeleteListAsync(IEnumerable<T> entities)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Set<T>().RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync() => _unitOfWork.CommitAsync();
    }
}
