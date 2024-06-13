using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Application.Common.SeedWork;
using MilkTeaManagement.Application.Contracts;
using MilkTeaManagement.Infrastructure.Common;
using MilkTeaManagement.Infrastructure.Configurations;
using MilkTeaManagement.Infrastructure.Data;
using MilkTeaManagement.Infrastructure.Repositories;
using MilkTeaManagement.Infrastructure.Services;

namespace MilkTeaManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddConfigurationSettings(configuration);
            services.ConfigureApplicationDbContext(configuration);
            services.ConfigureAzureSignalR(configuration);
            services.ConfigureInfrastructureServices();

            return services;
        }

        public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
        {
            using var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var section = configuration.GetSection(sectionName);
            var options = new T();
            section.Bind(options);

            return options;
        }

        public static IServiceCollection AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var emailSettings = configuration.GetSection(nameof(EmailSettings))
                .Get<EmailSettings>();
            services.AddSingleton(typeof(IEmailSettings), emailSettings);

            var azureBlobStorage = configuration.GetSection(nameof(AzureBlobStorage))
                .Get<AzureBlobStorage>();
            services.AddSingleton<AzureBlobStorage>(azureBlobStorage);

            return services;
        }

        private static IServiceCollection ConfigureApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnectionString");
            if (connectionString == null || string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("DefaultConnectionString is not configured.");
            services.AddDbContext<ApplicationDbContext>(m => m.UseSqlServer(connectionString));
            return services;
        }

        private static IServiceCollection ConfigureAzureSignalR(this IServiceCollection services, IConfiguration configuration)
        {
            var azureSignalR = configuration.GetValue<string>("AzureSignalR");
            if (azureSignalR == null || string.IsNullOrEmpty(azureSignalR))
                throw new ArgumentNullException("AzureSignalR is not configured.");
            services
                .AddSignalR()
                .AddAzureSignalR(azureSignalR);
            return services;
        }

        private static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services) =>
            services.AddScoped<ApplicationDbContextSeed>()
                .AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>))
                .AddScoped(typeof(IEmailService), typeof(EmailService))
                .AddScoped(typeof(IAzureBlobService), typeof(AzureBlobService))
                .AddTransient<IAuthRepository, AuthRepository>()
                .AddTransient<IUsersRepository, UsersRespository>()
                .AddTransient<ICategoriesRepository, CategoriesRepository>()
                .AddTransient<IProductsRepository, ProductsRepository>();
    }
}
