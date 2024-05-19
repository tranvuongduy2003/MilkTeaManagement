using Microsoft.EntityFrameworkCore;
using ILogger = Serilog.ILogger;

namespace MilkTeaManagement.Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;

        public ApplicationDbContextSeed(ILogger logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                if (!_context.Database.IsSqlServer())
                {
                    await _context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occured while initialising the database");
                throw;
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "An error occured while seeding the database");
                throw;
            }
        }

        public async Task TrySeedAsync()
        {
            //if (!_context.Orders.Any())
            //{
            //    await _context.Orders.AddAsync(
            //        new Order
            //        {
            //            UserName = "customer1",
            //            FirstName = "customer1",
            //            LastName = "customer",
            //            EmailAddress = "customer1@local.com",
            //            ShippingAddress = "Wollongong",
            //            InvoiceAddress = "Australia",
            //            TotalPrice = 20,
            //        });
            //}
        }
    }
}
