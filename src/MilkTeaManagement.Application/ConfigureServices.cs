using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MilkTeaManagement.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services) =>
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}
