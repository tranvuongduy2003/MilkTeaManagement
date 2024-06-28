namespace MilkTeaManagement.WindowsApp.Forms.Payments
{
    partial class PrintBillForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            lbDate = new Label();
            label6 = new Label();
            lbCustomerPhone = new Label();
            label8 = new Label();
            BillTable = new DataGridView();
            TT = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            SL = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            lbSubTotal = new Label();
            label7 = new Label();
            lbDiscount = new Label();
            label9 = new Label();
            lbTotal = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)BillTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(465, 57);
            label1.TabIndex = 3;
            label1.Text = "Milk Tea Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(50, 100);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(592, 46);
            label2.TabIndex = 4;
            label2.Text = "University of Information Technology";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(156, 200);
            lbDate.Margin = new Padding(0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(190, 46);
            lbDate.TabIndex = 10;
            lbDate.Text = "27/06/2024";
            lbDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(50, 200);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(100, 46);
            label6.TabIndex = 9;
            label6.Text = "Date:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCustomerPhone
            // 
            lbCustomerPhone.AutoSize = true;
            lbCustomerPhone.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCustomerPhone.ForeColor = Color.Black;
            lbCustomerPhone.Location = new Point(791, 200);
            lbCustomerPhone.Margin = new Padding(0);
            lbCustomerPhone.Name = "lbCustomerPhone";
            lbCustomerPhone.Size = new Size(200, 46);
            lbCustomerPhone.TabIndex = 12;
            lbCustomerPhone.Text = "0123123123";
            lbCustomerPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(613, 200);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(178, 46);
            label8.TabIndex = 11;
            label8.Text = "Customer:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BillTable
            // 
            BillTable.AllowUserToAddRows = false;
            BillTable.AllowUserToDeleteRows = false;
            BillTable.AllowUserToResizeColumns = false;
            BillTable.AllowUserToResizeRows = false;
            BillTable.BackgroundColor = Color.White;
            BillTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BillTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BillTable.ColumnHeadersHeight = 50;
            BillTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            BillTable.Columns.AddRange(new DataGridViewColumn[] { TT, ProductName, SL, Price });
            BillTable.Location = new Point(50, 270);
            BillTable.Margin = new Padding(0);
            BillTable.Name = "BillTable";
            BillTable.ReadOnly = true;
            BillTable.RowHeadersWidth = 50;
            BillTable.RowTemplate.Height = 50;
            BillTable.Size = new Size(941, 300);
            BillTable.TabIndex = 14;
            // 
            // TT
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TT.DefaultCellStyle = dataGridViewCellStyle2;
            TT.HeaderText = "TT";
            TT.MinimumWidth = 8;
            TT.Name = "TT";
            TT.ReadOnly = true;
            TT.Width = 50;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            ProductName.DefaultCellStyle = dataGridViewCellStyle3;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // SL
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SL.DefaultCellStyle = dataGridViewCellStyle4;
            SL.HeaderText = "SL";
            SL.MinimumWidth = 8;
            SL.Name = "SL";
            SL.ReadOnly = true;
            SL.Width = 200;
            // 
            // Price
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 200;
            // 
            // lbSubTotal
            // 
            lbSubTotal.AutoSize = true;
            lbSubTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubTotal.ForeColor = Color.Black;
            lbSubTotal.Location = new Point(791, 583);
            lbSubTotal.Margin = new Padding(0);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(202, 41);
            lbSubTotal.TabIndex = 16;
            lbSubTotal.Text = "100,000 VNĐ";
            lbSubTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(639, 583);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(152, 41);
            label7.TabIndex = 15;
            label7.Text = "Sub Total:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDiscount.ForeColor = Color.Black;
            lbDiscount.Location = new Point(791, 630);
            lbDiscount.Margin = new Padding(0);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(78, 41);
            lbDiscount.TabIndex = 18;
            lbDiscount.Text = "10%";
            lbDiscount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(644, 630);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(147, 41);
            label9.TabIndex = 17;
            label9.Text = "Discount:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(791, 680);
            lbTotal.Margin = new Padding(0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(202, 41);
            lbTotal.TabIndex = 20;
            lbTotal.Text = "100,000 VNĐ";
            lbTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(699, 680);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(92, 41);
            label10.TabIndex = 19;
            label10.Text = "Total:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PrintBillForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 750);
            Controls.Add(lbTotal);
            Controls.Add(label10);
            Controls.Add(lbDiscount);
            Controls.Add(label9);
            Controls.Add(lbSubTotal);
            Controls.Add(label7);
            Controls.Add(BillTable);
            Controls.Add(lbCustomerPhone);
            Controls.Add(label8);
            Controls.Add(lbDate);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrintBillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += PrintBillForm_Shown;
            ((System.ComponentModel.ISupportInitialize)BillTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbDate;
        private Label label6;
        private Label lbCustomerPhone;
        private Label label8;
        private DataGridView BillTable;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn Price;
        private Label lbSubTotal;
        private Label label7;
        private Label lbDiscount;
        private Label label9;
        private Label lbTotal;
        private Label label10;
    }
}