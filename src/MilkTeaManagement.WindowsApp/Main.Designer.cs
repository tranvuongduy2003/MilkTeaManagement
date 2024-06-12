namespace MilkTeaManagement.WindowsApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new PictureBox();
            contentPanel = new Panel();
            product = new UserControls.Sidebar.SidebarItem();
            home = new UserControls.Sidebar.SidebarItem();
            sidebarPanel = new Panel();
            employee = new UserControls.Sidebar.SidebarItem();
            category = new UserControls.Sidebar.SidebarItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 30);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(79, 673);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Transparent;
            close.BackgroundImage = Properties.Resources.multiply;
            close.BackgroundImageLayout = ImageLayout.Stretch;
            close.Location = new Point(1890, 0);
            close.Margin = new Padding(0);
            close.Name = "close";
            close.Size = new Size(30, 30);
            close.TabIndex = 12;
            close.TabStop = false;
            close.Click += close_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.Menu;
            contentPanel.Location = new Point(100, 30);
            contentPanel.Margin = new Padding(0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1820, 1050);
            contentPanel.TabIndex = 2;
            // 
            // product
            // 
            product.Location = new Point(0, 100);
            product.Margin = new Padding(0);
            product.Name = "product";
            product.Size = new Size(100, 100);
            product.TabIndex = 0;
            product.Click += product_Click;
            // 
            // home
            // 
            home.BackColor = Color.FromArgb(192, 192, 255);
            home.Location = new Point(0, 0);
            home.Margin = new Padding(0);
            home.Name = "home";
            home.Size = new Size(100, 100);
            home.TabIndex = 1;
            home.Click += home_Click;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(192, 192, 255);
            sidebarPanel.Controls.Add(employee);
            sidebarPanel.Controls.Add(category);
            sidebarPanel.Controls.Add(product);
            sidebarPanel.Controls.Add(home);
            sidebarPanel.Location = new Point(0, 30);
            sidebarPanel.Margin = new Padding(0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(100, 1050);
            sidebarPanel.TabIndex = 3;
            // 
            // employee
            // 
            employee.Location = new Point(0, 300);
            employee.Margin = new Padding(0);
            employee.Name = "employee";
            employee.Size = new Size(100, 100);
            employee.TabIndex = 3;
            employee.Click += employee_Click;
            // 
            // category
            // 
            category.Location = new Point(0, 200);
            category.Margin = new Padding(0);
            category.Name = "category";
            category.Size = new Size(100, 100);
            category.TabIndex = 2;
            category.Click += category_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1920, 1080);
            Controls.Add(sidebarPanel);
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            sidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private Panel contentPanel;
        private UserControls.Sidebar.SidebarItem product;
        private UserControls.Sidebar.SidebarItem home;
        private Panel sidebarPanel;
        private UserControls.Sidebar.SidebarItem category;
        private UserControls.Sidebar.SidebarItem employee;
    }
}
