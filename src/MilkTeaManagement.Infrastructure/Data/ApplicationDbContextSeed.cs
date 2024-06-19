using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Domain.Enums;

namespace MilkTeaManagement.Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        private const int MAX_EVENTS_QUANTITY = 20;
        private const int MAX_CATEGORIES_QUANTITY = 5;
        private const int MAX_USERS_QUANTITY = 10;

        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationDbContextSeed(ApplicationDbContext context, UserManager<User> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
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
                await SeedRoles();
                await SeedUsers();
                await SeedCategories();
                await SeedProducts();
                await SeedConversations();
                await SeedMessages();
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task SeedRoles()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = EUserRole.Admin.GetDisplayName(),
                });
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = EUserRole.Manager.GetDisplayName(),
                });
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = EUserRole.Cashier.GetDisplayName(),
                });
                await _roleManager.CreateAsync(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = EUserRole.Barista.GetDisplayName(),
                });
            }
            await _context.SaveChangesAsync();
        }

        private async Task SeedUsers()
        {
            if (!_userManager.Users.Any())
            {
                var fakerAdmin = new Faker<User>()
                   .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                   .RuleFor(c => c.Status, _ => EUserStatus.ACTIVE)
                   .RuleFor(c => c.Avatar, _ => "https://i.pravatar.cc/300")
                   .RuleFor(c => c.DOB, f => f.Person.DateOfBirth)
                   .RuleFor(c => c.Email, _ => "admin@gmail.com")
                   .RuleFor(c => c.FullName, _ => "Admin")
                   .RuleFor(c => c.Gender, _ => EGender.MALE)
                   .RuleFor(c => c.PhoneNumber, _ => "0829440357")
                   .RuleFor(c => c.UserName, _ => "admin");

                var generatedAdmin = fakerAdmin.Generate();
                var result = await _userManager.CreateAsync(generatedAdmin, "Admin@123");
                if (result.Succeeded)
                {
                    var admin = await _userManager.FindByEmailAsync(generatedAdmin.Email);
                    await _userManager.AddToRoleAsync(admin, EUserRole.Admin.GetDisplayName());
                }


                var fakerUser = new Faker<User>()
                   .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                   .RuleFor(c => c.Status, _ => EUserStatus.ACTIVE)
                   .RuleFor(c => c.Avatar, _ => "https://i.pravatar.cc/300")
                   .RuleFor(c => c.DOB, f => f.Person.DateOfBirth)
                   .RuleFor(c => c.Email, f => f.Person.Email)
                   .RuleFor(c => c.FullName, f => f.Person.FullName)
                   .RuleFor(c => c.Gender, f => f.PickRandom<EGender>())
                   .RuleFor(c => c.PhoneNumber, f => f.Person.Phone)
                   .RuleFor(c => c.UserName, f => f.Person.UserName);

                var generatedUsers = fakerUser.Generate(MAX_USERS_QUANTITY);
                foreach (var generatedUser in generatedUsers)
                {
                    var userResult = await _userManager.CreateAsync(generatedUser, "User@123");
                    if (userResult.Succeeded)
                    {
                        var user = await _userManager.FindByEmailAsync(generatedUser.Email);
                        await _userManager.AddToRoleAsync(user, new Faker().PickRandom<EUserRole>().GetDisplayName());
                    }
                }

                await _context.SaveChangesAsync();
            }
        }

        private async Task SeedCategories()
        {
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
        }

        private async Task SeedProducts()
        {
            if (!_context.Products.Any())
            {
                var categories = await _context.Categories.AsNoTracking().ToListAsync();

                var fakerProduct = new Faker<Product>()
                    .RuleFor(c => c.Id, _ => Guid.NewGuid().ToString())
                    .RuleFor(c => c.Poster, _ => "https://picsum.photos/180/260")
                    .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                    .RuleFor(c => c.Price, f => decimal.Parse(f.Commerce.Price(10000, 1000000, 0)))
                    .RuleFor(c => c.Status, f => f.PickRandom<EProductStatus>())
                    .RuleFor(c => c.CategoryId, f => f.PickRandom(categories).Id)
                    .RuleFor(c => c.Description, f => f.Commerce.ProductDescription())
                    .RuleFor(c => c.CreatedDate, _ => DateTimeOffset.UtcNow)
                    .RuleFor(c => c.UpdatedDate, _ => DateTimeOffset.UtcNow);

                var products = fakerProduct.Generate(20);
                await _context.Products.AddRangeAsync(products);
                await _context.SaveChangesAsync();
            }
        }

        private async Task SeedConversations()
        {
            if (_userManager.Users.Any() && !_context.Conversations.Any())
            {
                var users = _userManager.Users.AsNoTracking().ToList();

                for (int i = 0; i < users.Count; i++)
                {
                    for (int j = i + 1; j < users.Count; j++)
                    {
                        await _context.Conversations.AddAsync(new Conversation
                        {
                            UserOneId = users[i].Id,
                            UserTwoId = users[j].Id,
                        });
                        await _context.SaveChangesAsync();
                    }
                }

                await _context.Conversations.AddAsync(new Conversation
                {
                    UserOneId = Guid.NewGuid().ToString(),
                    UserTwoId = Guid.NewGuid().ToString(),
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task SeedMessages()
        {
            if (_context.Conversations.Any() && !_context.Messages.Any())
            {
                var conversations = _context.Conversations.AsNoTracking().ToList();

                foreach (var conversation in conversations)
                {
                    var fakerMessage = new Faker<Message>()
                        .RuleFor(m => m.ConversationId, _ => conversation.Id)
                        .RuleFor(m => m.SenderId, f => f.PickRandom<string>(conversation.UserOneId, conversation.UserTwoId))
                        .RuleFor(m => m.Content, f => f.Lorem.Text());

                    var messages = fakerMessage.Generate(20);
                    foreach (var message in messages)
                    {
                        message.ReceiverId = message.SenderId == conversation.UserOneId ? conversation.UserTwoId : conversation.UserOneId;
                        await _context.Messages.AddAsync(message);
                    }
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
