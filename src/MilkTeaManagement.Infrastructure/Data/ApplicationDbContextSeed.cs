using Bogus;
using Microsoft.EntityFrameworkCore;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbContextSeed(ApplicationDbContext context)
        {
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
                throw ex;
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
                throw ex;
            }
        }

        public async Task TrySeedAsync()
        {
            if (!_context.Users.Any())
            {
                var fakerUser = new Faker<User>()
                    .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                    .RuleFor(c => c.Status, _ => EUserStatus.ACTIVE)
                    .RuleFor(c => c.Avatar, _ => "https://i.pravatar.cc/300")
                    .RuleFor(c => c.DOB, f => f.Person.DateOfBirth)
                    .RuleFor(c => c.Email, _ => "tranvuongduy2003@gmail.com")
                    .RuleFor(c => c.FullName, _ => "Trần Vương Duy")
                    .RuleFor(c => c.Gender, _ => EGender.MALE)
                    .RuleFor(c => c.Password, _ => BCrypt.Net.BCrypt.HashPassword("Admin@123"))
                    .RuleFor(c => c.PhoneNumber, _ => "0829440357")
                    .RuleFor(c => c.UserName, _ => "admin")
                    .RuleFor(c => c.CreatedDate, _ => DateTimeOffset.UtcNow)
                    .RuleFor(c => c.UpdatedDate, _ => DateTimeOffset.UtcNow);

                var user = fakerUser.Generate(1).FirstOrDefault();
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }

            if (!_context.Categories.Any())
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == "admin");

                var fakerCategory = new Faker<Category>()
                    .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                    .RuleFor(c => c.Poster, _ => "https://picsum.photos/200")
                    .RuleFor(c => c.Name, f => f.Commerce.Categories(1).FirstOrDefault())
                    .RuleFor(c => c.CreatorId, _ => user.Id)
                    .RuleFor(c => c.CreatedDate, _ => DateTimeOffset.UtcNow)
                    .RuleFor(c => c.UpdatedDate, _ => DateTimeOffset.UtcNow);

                var categories = fakerCategory.Generate(10);
                await _context.Categories.AddRangeAsync(categories);
                await _context.SaveChangesAsync();
            }

            if (!_context.Products.Any())
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == "admin");
                var categories = await _context.Categories.ToListAsync();

                var fakerProduct = new Faker<Product>()
                    .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                    .RuleFor(c => c.Poster, _ => "https://picsum.photos/180/260")
                    .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                    .RuleFor(c => c.Price, f => decimal.Parse(f.Commerce.Price(10000, 1000000, 0)))
                    .RuleFor(c => c.Status, f => f.PickRandom<EProductStatus>())
                    .RuleFor(c => c.CategoryId, f => f.PickRandom(categories).Id)
                    .RuleFor(c => c.Description, f => f.Commerce.ProductDescription())
                    .RuleFor(c => c.CreatorId, _ => user.Id)
                    .RuleFor(c => c.CreatedDate, _ => DateTimeOffset.UtcNow)
                    .RuleFor(c => c.UpdatedDate, _ => DateTimeOffset.UtcNow);

                var products = fakerProduct.Generate(20);
                await _context.Products.AddRangeAsync(products);
                await _context.SaveChangesAsync();
            }
        }
    }
}
