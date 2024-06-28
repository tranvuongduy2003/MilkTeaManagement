using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.Mappings;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Domain.Entities;
using MilkTeaManagement.Infrastructure.Common;
using MilkTeaManagement.Infrastructure.Data;
using MilkTeaManagement.Infrastructure.Repositories;
using MilkTeaManagement.Infrastructure.Services;

namespace MilkTeaManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
        {
            using var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var section = configuration.GetSection(sectionName);
            var options = new T();
            section.Bind(options);

            return options;
        }

        public static IServiceCollection ConfigureMapping(this IServiceCollection services)
        {
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        public static IServiceCollection ConfigureApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            if (connectionString == null || string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("DefaultConnectionString is not configured.");
            services.AddDbContext<ApplicationDbContext>(m => m.UseSqlServer(connectionString));
            return services;
        }

        public static IServiceCollection ConfigureIndentity(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
            });

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }

        public static IServiceCollection ConfigureAzureSignalR(this IServiceCollection services, IConfiguration configuration)
        {
            var azureSignalR = configuration.GetValue<string>("AzureSignalR");
            if (azureSignalR == null || string.IsNullOrEmpty(azureSignalR))
                throw new ArgumentNullException("AzureSignalR is not configured.");
            services
                .AddSignalR()
                .AddAzureSignalR(azureSignalR);
            return services;
        }

        public static IServiceCollection ConfigureCors(this IServiceCollection services, string appCors)
        {
            services.AddCors(p =>
                p.AddPolicy(appCors, build =>
                {
                    build
                    .WithOrigins("*")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                }));

            return services;
        }

        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services) =>
            services
                .AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>))
                .AddScoped(typeof(IEmailService), typeof(EmailService))
                .AddScoped(typeof(IAzureBlobService), typeof(AzureBlobService))
                .AddTransient<ApplicationDbContextSeed>()
                .AddTransient<IAuthRepository, AuthRepository>()
                .AddTransient<ICategoriesRepository, CategoriesRepository>()
                .AddTransient<IOrdersRepository, OrdersRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>()
                .AddTransient<IConversationsRepository, ConversationsRepository>()
                .AddTransient<IMessagesRepository, MessagesRepository>()
                .AddTransient<IShiftsRepository, ShiftsRepository>();
    }
}
