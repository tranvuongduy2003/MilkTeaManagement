using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MilkTeaManagement.WindowsApp.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            //var eventBusSettings = configuration.GetSection(nameof(EventBusSettings))
            //    .Get<EventBusSettings>();
            //services.AddSingleton(eventBusSettings);

            return services;
        }
    }

}
