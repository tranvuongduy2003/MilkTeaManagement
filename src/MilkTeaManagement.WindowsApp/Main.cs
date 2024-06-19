using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.WindowsApp.Pages.Categories;
using MilkTeaManagement.WindowsApp.Pages.Chat;
using MilkTeaManagement.WindowsApp.Pages.Employees;
using MilkTeaManagement.WindowsApp.Pages.Home;
using MilkTeaManagement.WindowsApp.Pages.Products;
using MilkTeaManagement.WindowsApp.UserControls.Sidebar;

namespace MilkTeaManagement.WindowsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            home.pictureBox1.BackgroundImage = Properties.Resources.home;
            home.label1.Text = "Home";
            category.pictureBox1.BackgroundImage = Properties.Resources.options_lines;
            category.label1.Text = "Categories";
            product.pictureBox1.BackgroundImage = Properties.Resources.cutlery;
            product.label1.Text = "Products";
            employee.pictureBox1.BackgroundImage = Properties.Resources.user;
            employee.label1.Text = "Employees";
            chat.pictureBox1.BackgroundImage = Properties.Resources.bubble_chat;
            chat.label1.Text = "Chat";

            InitializeSignalR();

            // Load Home Page
            SetItemSelected(home);
            contentPanel.Controls.Clear();
            HomePage homePage = Program.ServiceProvider.GetRequiredService<HomePage>();
            homePage.OnLoad();
            contentPanel.Controls.Add(homePage);
        }

        private async Task OnCloseHubConnection()
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await Program.SignalRConnection?.StopAsync();
        }

        private async void InitializeSignalR()
        {
            Program.SignalRConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:8008/Chat", HttpTransportType.WebSockets)
                .WithAutomaticReconnect()
                .Build();

            try
            {
                await Program.SignalRConnection?.StartAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            HomePage homePage = Program.ServiceProvider.GetRequiredService<HomePage>();
            homePage.OnLoad();
            contentPanel.Controls.Add(homePage);
        }

        private void product_Click(object sender, EventArgs e)
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            ProductsPage productsPage = Program.ServiceProvider.GetRequiredService<ProductsPage>();
            productsPage.OnLoad();
            contentPanel.Controls.Add(productsPage);
        }

        private void category_Click(object sender, EventArgs e)
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            CategoriesPage categoriesPage = Program.ServiceProvider.GetRequiredService<CategoriesPage>();
            contentPanel.Controls.Add(categoriesPage);
        }

        private void employee_Click(object sender, EventArgs e)
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            EmployeesPage employeesPage = Program.ServiceProvider.GetRequiredService<EmployeesPage>();
            employeesPage.OnLoad();
            contentPanel.Controls.Add(employeesPage);
        }

        private void chat_Click(object sender, EventArgs e)
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            ChatPage chatPage = Program.ServiceProvider.GetRequiredService<ChatPage>();
            chatPage.OnLoad();
            contentPanel.Controls.Add(chatPage);
        }

        private async void close_Click(object sender, EventArgs e)
        {
            await OnCloseHubConnection();
            this.Close();
        }

        private void SetItemSelected(object sender)
        {
            foreach (SidebarItem control in sidebarPanel.Controls)
                control.BackColor = sidebarPanel.BackColor;
            var item = (SidebarItem)sender;
            item.BackColor = Color.FromArgb(128, 128, 255);
        }

        private async void Main_Leave(object sender, EventArgs e)
        {
            await OnCloseHubConnection();
        }
    }
}
