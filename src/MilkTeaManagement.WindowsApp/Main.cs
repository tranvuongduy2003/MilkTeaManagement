using Microsoft.Extensions.DependencyInjection;
using MilkTeaManagement.WindowsApp.Pages.Categories;
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

            // Load Home Page
            SetItemSelected(home);
            contentPanel.Controls.Clear();
            HomePage homePage = Program.ServiceProvider.GetRequiredService<HomePage>();
            homePage.OnLoad();
            contentPanel.Controls.Add(homePage);

            category.pictureBox1.BackgroundImage = Properties.Resources.options_lines;
            category.label1.Text = "Categories";

            product.pictureBox1.BackgroundImage = Properties.Resources.cutlery;
            product.label1.Text = "Products";

            employee.pictureBox1.BackgroundImage = Properties.Resources.user;
            employee.label1.Text = "Employees";
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
            contentPanel.Controls.Add(employeesPage);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetItemSelected(object sender)
        {
            foreach (SidebarItem control in sidebarPanel.Controls)
                control.BackColor = sidebarPanel.BackColor;
            var item = (SidebarItem)sender;
            item.BackColor = Color.FromArgb(128, 128, 255);
        }
    }
}
