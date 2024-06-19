using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.Infrastructure.Configurations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MilkTeaManagement.SignalR.Extentions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, string appCors)
        {
            services.ConfigureCors(appCors);
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    options.JsonSerializerOptions.NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals;
                    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;

                });
            services.ConfigureIndentity();
            services.AddConfigurationSettings(configuration);
            services.ConfigureApplicationDbContext(configuration);
            services.ConfigureAzureSignalR(configuration);
            services.ConfigureInfrastructureServices();
            services.ConfigureMapping();
            return services;
        }

        public static IServiceCollection AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var azureBlobStorage = configuration.GetSection(nameof(AzureBlobStorage))
                .Get<AzureBlobStorage>();
            services.AddSingleton<AzureBlobStorage>(azureBlobStorage);

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
    }
}

