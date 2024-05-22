namespace MilkTeaManagement.WindowsApp.Pages.Home
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
            MainPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ResultQuantity = new Label();
            CategoryName = new Label();
            CategoriesPanel = new FlowLayoutPanel();
            SearchTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CheckoutPanel = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            MainPanel.SuspendLayout();
            CheckoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(64, 64, 64);
            MainPanel.Controls.Add(flowLayoutPanel1);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(30, 433);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1160, 590);
            flowLayoutPanel1.TabIndex = 5;
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
            SearchTextBox.TabIndex = 2;
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
            // CheckoutPanel
            // 
            CheckoutPanel.BackColor = Color.DimGray;
            CheckoutPanel.Controls.Add(button1);
            CheckoutPanel.Controls.Add(panel1);
            CheckoutPanel.Controls.Add(flowLayoutPanel2);
            CheckoutPanel.Controls.Add(label12);
            CheckoutPanel.Controls.Add(label7);
            CheckoutPanel.Controls.Add(label11);
            CheckoutPanel.Controls.Add(label9);
            CheckoutPanel.Controls.Add(label10);
            CheckoutPanel.Controls.Add(label8);
            CheckoutPanel.Controls.Add(label6);
            CheckoutPanel.Controls.Add(label5);
            CheckoutPanel.Controls.Add(label4);
            CheckoutPanel.Controls.Add(label3);
            CheckoutPanel.Controls.Add(pictureBox1);
            CheckoutPanel.Location = new Point(1220, 0);
            CheckoutPanel.Margin = new Padding(0);
            CheckoutPanel.Name = "CheckoutPanel";
            CheckoutPanel.Size = new Size(600, 1050);
            CheckoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(20, 177);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(560, 600);
            flowLayoutPanel2.TabIndex = 3;
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
            // label11
            // 
            label11.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(148, 900);
            label11.Margin = new Padding(0);
            label11.Name = "label11";
            label11.Size = new Size(432, 42);
            label11.TabIndex = 2;
            label11.Text = "2,000,000 VNĐ";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(148, 843);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(432, 42);
            label9.TabIndex = 2;
            label9.Text = "10,000,000 VNĐ";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(148, 797);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(432, 42);
            label10.TabIndex = 2;
            label10.Text = "12,000,000 VNĐ";
            label10.TextAlign = ContentAlignment.TopRight;
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
            label5.Size = new Size(55, 42);
            label5.TabIndex = 2;
            label5.Text = "Bill";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(115, 59);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(142, 36);
            label4.TabIndex = 1;
            label4.Text = "Sheilla Poetri";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(115, 20);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(81, 36);
            label3.TabIndex = 1;
            label3.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.avatar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(20, 889);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 2);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 957);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(560, 66);
            button1.TabIndex = 5;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(CheckoutPanel);
            Controls.Add(MainPanel);
            Margin = new Padding(0);
            Name = "HomePage";
            Size = new Size(1820, 1050);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            CheckoutPanel.ResumeLayout(false);
            CheckoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Label label1;
        private Panel CheckoutPanel;
        private TextBox SearchTextBox;
        private Label label2;
        private Label CategoryName;
        private FlowLayoutPanel CategoriesPanel;
        private Label ResultQuantity;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Button button1;
    }
}
