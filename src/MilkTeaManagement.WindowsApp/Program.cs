using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkTeaManagement.Application;
using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.WindowsApp.Pages.Auth;
using MilkTeaManagement.WindowsApp.Pages.Categories;
using MilkTeaManagement.WindowsApp.Pages.Employees;
using MilkTeaManagement.WindowsApp.Pages.Home;
using MilkTeaManagement.WindowsApp.Pages.Products;

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

            builder.Configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            builder.Services.AddConfigurationSettings(builder.Configuration);

            builder.Services.AddInfrastructureServices(builder.Configuration);

            builder.Services.AddApplicationServices();

            // Main form
            builder.Services.AddSingleton<Main>();
            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<RegisterPage>();
            builder.Services.AddSingleton<ResetPasswordPage>();

            //Pages
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<CategoriesPage>();
            builder.Services.AddSingleton<ProductsPage>();
            builder.Services.AddSingleton<EmployeesPage>();

            return builder;
        }
    }
}