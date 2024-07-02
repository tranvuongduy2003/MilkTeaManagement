namespace MilkTeaManagement.WindowsApp.Pages.Dashboard
{
    partial class DashboardPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            lbTotalOrders = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lbTotalRevenue = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lbTotalSold = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnDay = new Button();
            btnMonth = new Button();
            btnYear = new Button();
            panel4 = new Panel();
            lbQuantity2 = new Label();
            pbProduct2 = new PictureBox();
            lbProductName2 = new Label();
            lbQuantity1 = new Label();
            label2 = new Label();
            pbProduct1 = new PictureBox();
            lbProductName1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 53, 51);
            panel1.Controls.Add(lbTotalOrders);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(20, 230);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 140);
            panel1.TabIndex = 0;
            // 
            // lbTotalOrders
            // 
            lbTotalOrders.AutoSize = true;
            lbTotalOrders.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalOrders.ForeColor = Color.FromArgb(215, 223, 236);
            lbTotalOrders.Location = new Point(160, 74);
            lbTotalOrders.Name = "lbTotalOrders";
            lbTotalOrders.Size = new Size(80, 46);
            lbTotalOrders.TabIndex = 2;
            lbTotalOrders.Text = "100";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(215, 223, 236);
            label1.Location = new Point(160, 20);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 1;
            label1.Text = "Total orders";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.order;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 53, 51);
            panel2.Controls.Add(lbTotalRevenue);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(508, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 140);
            panel2.TabIndex = 3;
            // 
            // lbTotalRevenue
            // 
            lbTotalRevenue.AutoSize = true;
            lbTotalRevenue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRevenue.ForeColor = Color.FromArgb(215, 223, 236);
            lbTotalRevenue.Location = new Point(160, 74);
            lbTotalRevenue.Name = "lbTotalRevenue";
            lbTotalRevenue.Size = new Size(80, 46);
            lbTotalRevenue.TabIndex = 2;
            lbTotalRevenue.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(215, 223, 236);
            label3.Location = new Point(160, 20);
            label3.Name = "label3";
            label3.Size = new Size(221, 46);
            label3.TabIndex = 1;
            label3.Text = "Total revenue";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.revenue;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(40, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(49, 53, 51);
            panel3.Controls.Add(lbTotalSold);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(997, 230);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 140);
            panel3.TabIndex = 3;
            // 
            // lbTotalSold
            // 
            lbTotalSold.AutoSize = true;
            lbTotalSold.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalSold.ForeColor = Color.FromArgb(215, 223, 236);
            lbTotalSold.Location = new Point(160, 74);
            lbTotalSold.Name = "lbTotalSold";
            lbTotalSold.Size = new Size(80, 46);
            lbTotalSold.TabIndex = 2;
            lbTotalSold.Text = "100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(215, 223, 236);
            label5.Location = new Point(160, 20);
            label5.Name = "label5";
            label5.Size = new Size(305, 46);
            label5.TabIndex = 1;
            label5.Text = "Total products sold";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.product;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(40, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // chartRevenue
            // 
            chartRevenue.BackColor = Color.FromArgb(49, 53, 51);
            chartArea1.BackColor = Color.FromArgb(31, 42, 64);
            chartArea1.Name = "ChartArea1";
            chartRevenue.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            legend1.ForeColor = Color.FromArgb(168, 170, 218);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            chartRevenue.Legends.Add(legend1);
            chartRevenue.Location = new Point(20, 440);
            chartRevenue.Name = "chartRevenue";
            chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRevenue.Series.Add(series1);
            chartRevenue.Size = new Size(1477, 415);
            chartRevenue.TabIndex = 4;
            chartRevenue.Text = "chart1";
            // 
            // btnDay
            // 
            btnDay.BackColor = Color.FromArgb(119, 122, 202);
            btnDay.FlatAppearance.BorderColor = Color.FromArgb(168, 170, 218);
            btnDay.FlatAppearance.BorderSize = 2;
            btnDay.FlatStyle = FlatStyle.Flat;
            btnDay.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDay.ForeColor = Color.FromArgb(215, 223, 236);
            btnDay.Location = new Point(450, 380);
            btnDay.Name = "btnDay";
            btnDay.Size = new Size(177, 50);
            btnDay.TabIndex = 5;
            btnDay.Text = "Day";
            btnDay.UseVisualStyleBackColor = false;
            btnDay.Click += btnDay_Click;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.FromArgb(81, 86, 190);
            btnMonth.FlatAppearance.BorderColor = Color.FromArgb(168, 170, 218);
            btnMonth.FlatAppearance.BorderSize = 2;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonth.ForeColor = Color.FromArgb(215, 223, 236);
            btnMonth.Location = new Point(637, 380);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(177, 50);
            btnMonth.TabIndex = 6;
            btnMonth.Text = "Month";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnYear
            // 
            btnYear.BackColor = Color.FromArgb(81, 86, 190);
            btnYear.FlatAppearance.BorderColor = Color.FromArgb(168, 170, 218);
            btnYear.FlatAppearance.BorderSize = 2;
            btnYear.FlatStyle = FlatStyle.Flat;
            btnYear.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYear.ForeColor = Color.FromArgb(215, 223, 236);
            btnYear.Location = new Point(822, 380);
            btnYear.Name = "btnYear";
            btnYear.Size = new Size(177, 50);
            btnYear.TabIndex = 7;
            btnYear.Text = "Year";
            btnYear.UseVisualStyleBackColor = false;
            btnYear.Click += btnYear_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(49, 53, 51);
            panel4.Controls.Add(lbQuantity2);
            panel4.Controls.Add(pbProduct2);
            panel4.Controls.Add(lbProductName2);
            panel4.Controls.Add(lbQuantity1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pbProduct1);
            panel4.Controls.Add(lbProductName1);
            panel4.Location = new Point(20, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(1477, 200);
            panel4.TabIndex = 3;
            // 
            // lbQuantity2
            // 
            lbQuantity2.AutoSize = true;
            lbQuantity2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuantity2.ForeColor = Color.FromArgb(215, 223, 236);
            lbQuantity2.Location = new Point(1157, 129);
            lbQuantity2.Name = "lbQuantity2";
            lbQuantity2.Size = new Size(80, 46);
            lbQuantity2.TabIndex = 7;
            lbQuantity2.Text = "100";
            // 
            // pbProduct2
            // 
            pbProduct2.BackgroundImageLayout = ImageLayout.Stretch;
            pbProduct2.Location = new Point(977, 25);
            pbProduct2.Name = "pbProduct2";
            pbProduct2.Size = new Size(150, 150);
            pbProduct2.TabIndex = 6;
            pbProduct2.TabStop = false;
            // 
            // lbProductName2
            // 
            lbProductName2.AutoSize = true;
            lbProductName2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductName2.ForeColor = Color.FromArgb(215, 223, 236);
            lbProductName2.Location = new Point(1157, 60);
            lbProductName2.Name = "lbProductName2";
            lbProductName2.Size = new Size(80, 46);
            lbProductName2.TabIndex = 5;
            lbProductName2.Text = "100";
            // 
            // lbQuantity1
            // 
            lbQuantity1.AutoSize = true;
            lbQuantity1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbQuantity1.ForeColor = Color.FromArgb(215, 223, 236);
            lbQuantity1.Location = new Point(220, 129);
            lbQuantity1.Name = "lbQuantity1";
            lbQuantity1.Size = new Size(80, 46);
            lbQuantity1.TabIndex = 4;
            lbQuantity1.Text = "100";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(215, 223, 236);
            label2.Location = new Point(653, 10);
            label2.Name = "label2";
            label2.Size = new Size(170, 46);
            label2.TabIndex = 3;
            label2.Text = "Best seller";
            // 
            // pbProduct1
            // 
            pbProduct1.BackgroundImageLayout = ImageLayout.Stretch;
            pbProduct1.Location = new Point(40, 25);
            pbProduct1.Name = "pbProduct1";
            pbProduct1.Size = new Size(150, 150);
            pbProduct1.TabIndex = 3;
            pbProduct1.TabStop = false;
            // 
            // lbProductName1
            // 
            lbProductName1.AutoSize = true;
            lbProductName1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbProductName1.ForeColor = Color.FromArgb(215, 223, 236);
            lbProductName1.Location = new Point(220, 60);
            lbProductName1.Name = "lbProductName1";
            lbProductName1.Size = new Size(80, 46);
            lbProductName1.TabIndex = 2;
            lbProductName1.Text = "100";
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel4);
            Controls.Add(btnYear);
            Controls.Add(btnMonth);
            Controls.Add(btnDay);
            Controls.Add(chartRevenue);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DashboardPage";
            Size = new Size(1517, 875);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRevenue).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProduct2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProduct1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTotalOrders;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lbTotalRevenue;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lbTotalSold;
        private Label label5;
        private PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Button btnDay;
        private Button btnMonth;
        private Button btnYear;
        private Panel panel4;
        private Label lbProductName1;
        private PictureBox pbProduct1;
        private Label label2;
        private Label lbQuantity1;
        private Label lbQuantity2;
        private PictureBox pbProduct2;
        private Label lbProductName2;
    }
}
