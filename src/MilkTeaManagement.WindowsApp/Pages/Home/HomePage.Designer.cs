﻿namespace MilkTeaManagement.WindowsApp.Pages.Home
{
    partial class HomePage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CheckoutPanel = new Panel();
            CustomerPhone = new TextBox();
            Apply = new Button();
            DiscountPercent = new TextBox();
            CheckoutButton = new Button();
            panel1 = new Panel();
            invoicePanel = new FlowLayoutPanel();
            label12 = new Label();
            label7 = new Label();
            Total = new Label();
            Discount = new Label();
            SubTotal = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            FullName = new Label();
            Role = new Label();
            Avatar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            SearchTextBox = new TextBox();
            CategoriesPanel = new FlowLayoutPanel();
            CategoryName = new Label();
            ResultQuantity = new Label();
            ProductsPanel = new FlowLayoutPanel();
            MainPanel = new Panel();
            CheckoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CheckoutPanel
            // 
            CheckoutPanel.BackColor = Color.DimGray;
            CheckoutPanel.Controls.Add(CustomerPhone);
            CheckoutPanel.Controls.Add(Apply);
            CheckoutPanel.Controls.Add(DiscountPercent);
            CheckoutPanel.Controls.Add(CheckoutButton);
            CheckoutPanel.Controls.Add(panel1);
            CheckoutPanel.Controls.Add(invoicePanel);
            CheckoutPanel.Controls.Add(label12);
            CheckoutPanel.Controls.Add(label7);
            CheckoutPanel.Controls.Add(Total);
            CheckoutPanel.Controls.Add(Discount);
            CheckoutPanel.Controls.Add(SubTotal);
            CheckoutPanel.Controls.Add(label8);
            CheckoutPanel.Controls.Add(label6);
            CheckoutPanel.Controls.Add(label5);
            CheckoutPanel.Controls.Add(FullName);
            CheckoutPanel.Controls.Add(Role);
            CheckoutPanel.Controls.Add(Avatar);
            CheckoutPanel.Location = new Point(1220, 0);
            CheckoutPanel.Margin = new Padding(0);
            CheckoutPanel.Name = "CheckoutPanel";
            CheckoutPanel.Size = new Size(600, 1050);
            CheckoutPanel.TabIndex = 1;
            // 
            // CustomerPhone
            // 
            CustomerPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhone.Font = new Font("Poppins", 12F);
            CustomerPhone.Location = new Point(20, 680);
            CustomerPhone.Margin = new Padding(0);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.PlaceholderText = "  Enter customer phone number";
            CustomerPhone.Size = new Size(560, 43);
            CustomerPhone.TabIndex = 13;
            // 
            // Apply
            // 
            Apply.BackColor = Color.SteelBlue;
            Apply.Font = new Font("Poppins", 11F);
            Apply.ForeColor = Color.White;
            Apply.Location = new Point(437, 738);
            Apply.Margin = new Padding(0);
            Apply.Name = "Apply";
            Apply.Size = new Size(143, 43);
            Apply.TabIndex = 12;
            Apply.Text = "Apply";
            Apply.UseVisualStyleBackColor = false;
            Apply.Click += Apply_Click;
            // 
            // DiscountPercent
            // 
            DiscountPercent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountPercent.BorderStyle = BorderStyle.FixedSingle;
            DiscountPercent.Font = new Font("Poppins", 12F);
            DiscountPercent.Location = new Point(20, 738);
            DiscountPercent.Margin = new Padding(0);
            DiscountPercent.Name = "DiscountPercent";
            DiscountPercent.PlaceholderText = "  Enter discount percent (%)";
            DiscountPercent.Size = new Size(400, 43);
            DiscountPercent.TabIndex = 11;
            // 
            // CheckoutButton
            // 
            CheckoutButton.BackColor = Color.Coral;
            CheckoutButton.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckoutButton.ForeColor = Color.White;
            CheckoutButton.Location = new Point(20, 957);
            CheckoutButton.Margin = new Padding(0);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(560, 66);
            CheckoutButton.TabIndex = 5;
            CheckoutButton.Text = "Checkout";
            CheckoutButton.UseVisualStyleBackColor = false;
            CheckoutButton.Click += CheckoutButton_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(20, 889);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 2);
            panel1.TabIndex = 4;
            // 
            // invoicePanel
            // 
            invoicePanel.AutoScroll = true;
            invoicePanel.BorderStyle = BorderStyle.FixedSingle;
            invoicePanel.Location = new Point(20, 177);
            invoicePanel.Margin = new Padding(0);
            invoicePanel.Name = "invoicePanel";
            invoicePanel.Size = new Size(560, 483);
            invoicePanel.TabIndex = 3;
            // 
            // label12
            // 
            label12.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(20, 900);
            label12.Margin = new Padding(0);
            label12.Name = "label12";
            label12.Size = new Size(128, 36);
            label12.TabIndex = 2;
            label12.Text = "Total";
            // 
            // label7
            // 
            label7.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(20, 843);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(128, 36);
            label7.TabIndex = 2;
            label7.Text = "Discount";
            // 
            // Total
            // 
            Total.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Total.ForeColor = Color.White;
            Total.Location = new Point(148, 900);
            Total.Margin = new Padding(0);
            Total.Name = "Total";
            Total.Size = new Size(432, 42);
            Total.TabIndex = 2;
            Total.Text = "0 VNĐ";
            Total.TextAlign = ContentAlignment.TopRight;
            // 
            // Discount
            // 
            Discount.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Discount.ForeColor = Color.White;
            Discount.Location = new Point(148, 843);
            Discount.Margin = new Padding(0);
            Discount.Name = "Discount";
            Discount.Size = new Size(432, 42);
            Discount.TabIndex = 2;
            Discount.Text = "0 VNĐ";
            Discount.TextAlign = ContentAlignment.TopRight;
            // 
            // SubTotal
            // 
            SubTotal.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubTotal.ForeColor = Color.White;
            SubTotal.Location = new Point(148, 797);
            SubTotal.Margin = new Padding(0);
            SubTotal.Name = "SubTotal";
            SubTotal.Size = new Size(432, 42);
            SubTotal.TabIndex = 2;
            SubTotal.Text = "0 VNĐ";
            SubTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(148, 797);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(432, 42);
            label8.TabIndex = 2;
            label8.Text = "Sub Total";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Font = new Font("Poppins Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 797);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(128, 42);
            label6.TabIndex = 2;
            label6.Text = "Sub Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 115);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(111, 42);
            label5.TabIndex = 2;
            label5.Text = "Invoice";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName.ForeColor = Color.White;
            FullName.Location = new Point(115, 59);
            FullName.Margin = new Padding(0);
            FullName.Name = "FullName";
            FullName.Size = new Size(142, 36);
            FullName.TabIndex = 1;
            FullName.Text = "Sheilla Poetri";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role.ForeColor = Color.Gainsboro;
            Role.Location = new Point(115, 20);
            Role.Margin = new Padding(0);
            Role.Name = "Role";
            Role.Size = new Size(81, 36);
            Role.TabIndex = 1;
            Role.Text = "Admin";
            // 
            // Avatar
            // 
            Avatar.BackgroundImage = Properties.Resources.avatar;
            Avatar.BackgroundImageLayout = ImageLayout.Stretch;
            Avatar.Location = new Point(20, 20);
            Avatar.Margin = new Padding(0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(75, 75);
            Avatar.TabIndex = 0;
            Avatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(456, 70);
            label1.TabIndex = 0;
            label1.Text = "Welcome to MilkTea";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 89);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(247, 42);
            label2.TabIndex = 1;
            label2.Text = "Choose a category";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Poppins", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(657, 37);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Enter food or drink";
            SearchTextBox.Size = new Size(533, 55);
            SearchTextBox.TabIndex = 10;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // CategoriesPanel
            // 
            CategoriesPanel.AutoScroll = true;
            CategoriesPanel.Location = new Point(30, 137);
            CategoriesPanel.Margin = new Padding(0);
            CategoriesPanel.Name = "CategoriesPanel";
            CategoriesPanel.Size = new Size(1160, 230);
            CategoriesPanel.TabIndex = 3;
            CategoriesPanel.WrapContents = false;
            // 
            // CategoryName
            // 
            CategoryName.AutoSize = true;
            CategoryName.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CategoryName.ForeColor = Color.White;
            CategoryName.Location = new Point(30, 377);
            CategoryName.Margin = new Padding(0);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(139, 42);
            CategoryName.TabIndex = 4;
            CategoryName.Text = "Category";
            CategoryName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ResultQuantity
            // 
            ResultQuantity.AutoSize = true;
            ResultQuantity.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultQuantity.ForeColor = Color.White;
            ResultQuantity.Location = new Point(1058, 384);
            ResultQuantity.Margin = new Padding(0);
            ResultQuantity.Name = "ResultQuantity";
            ResultQuantity.Size = new Size(125, 42);
            ResultQuantity.TabIndex = 4;
            ResultQuantity.Text = "0 Results";
            ResultQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductsPanel
            // 
            ProductsPanel.AutoScroll = true;
            ProductsPanel.Location = new Point(30, 433);
            ProductsPanel.Margin = new Padding(0);
            ProductsPanel.Name = "ProductsPanel";
            ProductsPanel.Size = new Size(1160, 590);
            ProductsPanel.TabIndex = 5;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(64, 64, 64);
            MainPanel.Controls.Add(ProductsPanel);
            MainPanel.Controls.Add(ResultQuantity);
            MainPanel.Controls.Add(CategoryName);
            MainPanel.Controls.Add(CategoriesPanel);
            MainPanel.Controls.Add(SearchTextBox);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label1);
            MainPanel.Location = new Point(0, 0);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1220, 1050);
            MainPanel.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.Control;
            Controls.Add(CheckoutPanel);
            Controls.Add(MainPanel);
            Margin = new Padding(0);
            Name = "HomePage";
            Size = new Size(1820, 1050);
            CheckoutPanel.ResumeLayout(false);
            CheckoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel CheckoutPanel;
        private Label Role;
        private PictureBox Avatar;
        private Label label5;
        private Label FullName;
        private FlowLayoutPanel invoicePanel;
        private Label label7;
        private Label Discount;
        private Label SubTotal;
        private Label label8;
        private Label label6;
        private Label label12;
        private Label Total;
        private Panel panel1;
        private Button CheckoutButton;
        private TextBox DiscountPercent;
        private Button Apply;
        private TextBox CustomerPhone;
        private Label label1;
        private Label label2;
        private TextBox SearchTextBox;
        private FlowLayoutPanel CategoriesPanel;
        private Label CategoryName;
        private Label ResultQuantity;
        private FlowLayoutPanel ProductsPanel;
        private Panel MainPanel;
    }
}
