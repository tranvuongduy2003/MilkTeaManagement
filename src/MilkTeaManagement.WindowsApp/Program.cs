using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MilkTeaManagement.Application;
using MilkTeaManagement.Domain.ValueObjetcs;
using MilkTeaManagement.Infrastructure.Data;
using MilkTeaManagement.WindowsApp.Forms;
using MilkTeaManagement.WindowsApp.Forms.Categories;
using MilkTeaManagement.WindowsApp.Forms.Products;
using MilkTeaManagement.WindowsApp.Extensions;
using MilkTeaManagement.WindowsApp.Pages.Auth;

namespace MilkTeaManagement.WindowsApp
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static UserIdentity? UserIdentity { get; set; } = new();
        public static HubConnection? SignalRConnection { get; set; }

        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();

                try
                {
                    if (context.Database.GetPendingMigrations().Count() > 0)
                        context.Database.Migrate();
                    var dbInitializer = services.GetService<ApplicationDbContextSeed>();
                    dbInitializer?.SeedAsync().Wait();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while seeding the database.");
                }
            }

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<LoginPage>());
        }

        static HostApplicationBuilder CreateHostBuilder()
        {
            var builder = Host.CreateApplicationBuilder();

            builder.Configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddApplicationServices();

            builder.Services.AddSingleton<UserIdentity>(UserIdentity);

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
            builder.Services.AddScoped<UpdateProductForm>();
            builder.Services.AddScoped<InformationPanel>();
            builder.Services.AddScoped<BillItem>();

            builder.Services.AddScoped<CreateCategoryForm>();
            builder.Services.AddScoped<UpdateCategoryForm>();

            return builder;
        }
    }
}