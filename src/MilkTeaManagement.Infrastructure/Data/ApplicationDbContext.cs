using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Domain.Common.Interfaces;
using MilkTeaManagement.Domain.Entities;
using System.Reflection;

namespace MilkTeaManagement.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

            builder.Entity<User>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
            builder.Entity<IdentityRole>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
            builder.Entity<Product>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
            builder.Entity<Category>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
            builder.Entity<Order>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);
            builder.Entity<OrderItem>().Property(x => x.Id).HasMaxLength(50).IsUnicode(false);

            builder.Entity<Order>()
                    .HasMany(x => x.OrderItems)
                    .WithOne(x => x.Order)
                    .HasForeignKey(x => x.OrderId);
            builder.Entity<Product>()
                    .HasMany(x => x.OrderItems)
                    .WithOne(x => x.Product)
                    .HasForeignKey(x => x.ProductId);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var modified = ChangeTracker.Entries()
                 .Where(e => e.State == EntityState.Modified ||
                         e.State == EntityState.Added ||
                         e.State == EntityState.Deleted);

            foreach (var item in modified)
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        if (item.Entity is IDateTracking addedEntity)
                        {
                            addedEntity.CreatedDate = DateTime.UtcNow;
                            item.State = EntityState.Added;
                        }
                        break;

                    case EntityState.Modified:
                        Entry(item.Entity).Property("Id").IsModified = false;
                        if (item.Entity is IDateTracking modifiedEntity)
                        {
                            modifiedEntity.UpdatedDate = DateTime.UtcNow;
                            item.State = EntityState.Modified;
                        }
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }

}
