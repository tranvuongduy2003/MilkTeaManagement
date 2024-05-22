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

            return services;
        }


        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"),
                    builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<ApplicationDbContextSeed>();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddScoped(typeof(IEmailService), typeof(EmailService));

            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUsersRepository, UsersRespository>();

            return services;
        }
    }
}
