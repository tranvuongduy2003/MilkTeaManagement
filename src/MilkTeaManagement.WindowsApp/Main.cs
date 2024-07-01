using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.Domain.Enums;
using MilkTeaManagement.WindowsApp.Helpers;
using MilkTeaManagement.WindowsApp.Pages.Auth;
using MilkTeaManagement.WindowsApp.Pages.Categories;
using MilkTeaManagement.WindowsApp.Pages.Chat;
using MilkTeaManagement.WindowsApp.Pages.Employees;
using MilkTeaManagement.WindowsApp.Pages.Home;
using MilkTeaManagement.WindowsApp.Pages.Payments;
using MilkTeaManagement.WindowsApp.Pages.Products;
using MilkTeaManagement.WindowsApp.Pages.Profile;
using MilkTeaManagement.WindowsApp.UserControls.Sidebar;
using System.Runtime.InteropServices;

namespace MilkTeaManagement.WindowsApp
{
    public partial class Main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Main()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));

            home.pictureBox1.BackgroundImage = Properties.Resources.home;
            home.label1.Text = "Home";
            category.pictureBox1.BackgroundImage = Properties.Resources.options_lines;
            category.label1.Text = "Categories";
            product.pictureBox1.BackgroundImage = Properties.Resources.cutlery;
            product.label1.Text = "Products";
            employee.pictureBox1.BackgroundImage = Properties.Resources.user;
            employee.label1.Text = "Employees";
            payments.pictureBox1.BackgroundImage = Properties.Resources.invoice;
            payments.label1.Text = "Payments";
            chat.pictureBox1.BackgroundImage = Properties.Resources.bubble_chat;
            chat.label1.Text = "Chat";

            profile.pictureBox1.BackgroundImage = Properties.Resources.profile_user;
            profile.label1.Text = "Profile";
            logout.pictureBox1.BackgroundImage = Properties.Resources.logout;
            logout.label1.Text = "Logout";

            if (Program.UserIdentity.Role == nameof(EUserRole.Cashier) || Program.UserIdentity.Role == nameof(EUserRole.Barista))
            {
                category.Hide();
                product.Hide();
                employee.Hide();
                payments.Hide();
                chat.Location = new Point(0, home.Location.Y + home.Height);
            }
            else if (Program.UserIdentity.Role == nameof(EUserRole.Manager))
            {
                category.Hide();
                product.Hide();
                employee.Location = new Point(0, home.Location.Y + home.Height);
                payments.Location = new Point(0, employee.Location.Y + employee.Height);
                chat.Location = new Point(0, payments.Location.Y + payments.Height);
            }

            InitializeSignalR();

            LoadPage<HomePage>(this.home, null);
        }

        private async void Main_Leave(object sender, EventArgs e) => await OnCloseHubConnection();

        private async Task OnCloseHubConnection()
        {
            await Task.Delay(new Random().Next(0, 5) * 1000);
            await Program.SignalRConnection?.StopAsync();
        }

        private async void InitializeSignalR()
        {
            Program.SignalRConnection = new HubConnectionBuilder()
                //.WithUrl("https://milkteamanagementsignalr.azurewebsites.net/Chat", HttpTransportType.WebSockets)
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

        private void home_Click(object sender, EventArgs e) => LoadPage<HomePage>(sender, e);

        private void product_Click(object sender, EventArgs e) => LoadPage<ProductsPage>(sender, e);

        private void category_Click(object sender, EventArgs e) => LoadPage<CategoriesPage>(sender, e);

        private void employee_Click(object sender, EventArgs e) => LoadPage<EmployeesPage>(sender, e);

        private void chat_Click(object sender, EventArgs e) => LoadPage<ChatPage>(sender, e);

        private void payments_Click(object sender, EventArgs e) => LoadPage<PaymentsPage>(sender, e);

        private void profile_Click(object sender, EventArgs e) => LoadPage<ProfilePage>(sender, e);

        private async void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            await OnCloseHubConnection();
            LoginPage loginForm = Program.ServiceProvider.GetRequiredService<LoginPage>();
            loginForm.Show();
            loginForm.FocusUserNameTextBox();
        }

        private async void close_Click(object sender, EventArgs e)
        {
            await OnCloseHubConnection();
            this.Close();
        }

        public void LoadPage<T>(object sender, EventArgs e) where T : Page
        {
            SetItemSelected(sender);
            contentPanel.Controls.Clear();
            var page = Program.ServiceProvider.GetRequiredService<T>();
            page.OnLoad();
            contentPanel.Controls.Add(page);
        }

        public void SetItemSelected(object sender)
        {
            foreach (SidebarItem control in sidebarPanel.Controls)
                control.BackColor = sidebarPanel.BackColor;
            var item = (SidebarItem)sender;
            item.BackColor = Color.FromArgb(128, 128, 255);
        }
    }
}
