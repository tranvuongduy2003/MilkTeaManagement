using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkTeaManagement.Application;
using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.WindowsApp.Extensions;

namespace MilkTeaManagement.WindowsApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<Main>());
        }

        static HostApplicationBuilder CreateHostBuilder()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            builder.Services.AddInfrastructureServices(builder.Configuration);

            builder.Services.AddConfigurationSettings(builder.Configuration);

            builder.Services.AddApplicationServices();

            // Main form
            builder.Services.AddSingleton<Main>();

            return builder;
        }
    }
}