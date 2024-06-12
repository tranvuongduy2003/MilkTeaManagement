using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkTeaManagement.Application;
using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.Infrastructure.Data;
using MilkTeaManagement.WindowsApp.Forms;
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

            using (var scope = ServiceProvider.CreateScope())
            {
                var context = ServiceProvider.GetRequiredService<ApplicationDbContext>();

                try
                {
                    if (context.Database.GetPendingMigrations().Count() > 0)
                        context.Database.Migrate();
                    var seeder = ServiceProvider.GetService<ApplicationDbContextSeed>();
                    seeder?.SeedAsync().Wait();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<Main>());
        }

        static HostApplicationBuilder CreateHostBuilder()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            builder.Services.AddInfrastructureServices(builder.Configuration);

            builder.Services.AddApplicationServices();

            // Main form
            builder.Services.AddTransient<Main>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<RegisterPage>();
            builder.Services.AddTransient<ResetPasswordPage>();

            //Pages
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<CategoriesPage>();
            builder.Services.AddTransient<ProductsPage>();
            builder.Services.AddTransient<EmployeesPage>();

            builder.Services.AddScoped<CreateProductForm>();

            return builder;
        }
    }
}