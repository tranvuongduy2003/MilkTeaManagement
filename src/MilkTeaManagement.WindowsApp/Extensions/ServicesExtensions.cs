using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.Infrastructure.Configurations;

namespace MilkTeaManagement.WindowsApp.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddConfigurationSettings(configuration);
            services.ConfigureApplicationDbContext(configuration);
            services.ConfigureInfrastructureServices();
            services.ConfigureIndentity();
            services.ConfigureMapping();
            return services;
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
    }
}
