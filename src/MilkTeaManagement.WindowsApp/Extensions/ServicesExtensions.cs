using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Application.Common.Interfaces;
using MilkTeaManagement.Domain.ValueObjetcs;
using MilkTeaManagement.Infrastructure;
using MilkTeaManagement.Infrastructure.Configurations;
using MilkTeaManagement.WindowsApp.Forms;
using MilkTeaManagement.WindowsApp.Forms.Categories;
using MilkTeaManagement.WindowsApp.Forms.Employees;
using MilkTeaManagement.WindowsApp.Forms.Products;
using MilkTeaManagement.WindowsApp.Pages.Auth;
using MilkTeaManagement.WindowsApp.Pages.Categories;
using MilkTeaManagement.WindowsApp.Pages.Chat;
using MilkTeaManagement.WindowsApp.Pages.Employees;
using MilkTeaManagement.WindowsApp.Pages.Home;
using MilkTeaManagement.WindowsApp.Pages.Payments;
using MilkTeaManagement.WindowsApp.Pages.Products;
using MilkTeaManagement.WindowsApp.Pages.Profile;
using MilkTeaManagement.WindowsApp.UserControls.Chat;
using MilkTeaManagement.WindowsApp.UserControls.Employees;
using MilkTeaManagement.WindowsApp.UserControls.Home;

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
            services.ConfigureInternalInfrastructureServices();
            return services;
        }

        private static IServiceCollection AddConfigurationSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var emailSettings = configuration.GetSection(nameof(EmailSettings))
                .Get<EmailSettings>();
            services.AddSingleton(typeof(IEmailSettings), emailSettings);

            var azureBlobStorage = configuration.GetSection(nameof(AzureBlobStorage))
                .Get<AzureBlobStorage>();
            services.AddSingleton<AzureBlobStorage>(azureBlobStorage);

            return services;
        }

        private static IServiceCollection ConfigureInternalInfrastructureServices(this IServiceCollection services)
        {
            // Global State
            services.AddSingleton<UserIdentity>(Program.UserIdentity);

            // Main form
            services.AddSingleton<Main>();
            services.AddSingleton<LoginPage>();
            services.AddSingleton<RegisterPage>();
            services.AddSingleton<ResetPasswordPage>();

            // Pages
            services.AddScoped<HomePage>();
            services.AddScoped<CategoriesPage>();
            services.AddScoped<ProductsPage>();
            services.AddScoped<EmployeesPage>();
            services.AddScoped<PaymentsPage>();
            services.AddScoped<ChatPage>();
            services.AddScoped<ProfilePage>();

            // User Controls
            services.AddScoped<CreateProductForm>();
            services.AddScoped<UpdateProductForm>();
            services.AddScoped<CreateCategoryForm>();
            services.AddScoped<UpdateCategoryForm>();
            services.AddScoped<CreateEmployeeForm>();
            services.AddScoped<DetailEmployeeForm>();
            services.AddScoped<CheckoutHistory>();
            services.AddScoped<WorkDays>();
            services.AddScoped<BillItem>();
            services.AddScoped<ChatViewPanel>();

            return services;
        }
    }
}
