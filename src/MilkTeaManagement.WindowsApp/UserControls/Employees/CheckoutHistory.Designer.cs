namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    partial class CheckoutHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            OrdersTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            CustomerPhone = new DataGridViewTextBoxColumn();
            EmployeeId = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            delete = new Button();
            SearchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)OrdersTable).BeginInit();
            SuspendLayout();
            // 
            // OrdersTable
            // 
            OrdersTable.AllowUserToAddRows = false;
            OrdersTable.AllowUserToDeleteRows = false;
            OrdersTable.AllowUserToResizeColumns = false;
            OrdersTable.AllowUserToResizeRows = false;
            OrdersTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            OrdersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            OrdersTable.ColumnHeadersHeight = 50;
            OrdersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            OrdersTable.Columns.AddRange(new DataGridViewColumn[] { Id, TotalPrice, Discount, CustomerPhone, EmployeeId, CreatedAt });
            OrdersTable.Location = new Point(0, 70);
            OrdersTable.Margin = new Padding(0);
            OrdersTable.Name = "OrdersTable";
            OrdersTable.ReadOnly = true;
            OrdersTable.RowHeadersWidth = 50;
            OrdersTable.RowTemplate.Height = 50;
            OrdersTable.Size = new Size(1180, 835);
            OrdersTable.TabIndex = 23;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 8;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 8;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 250;
            TotalPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 8;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Width = 250;
            Discount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Discount.Visible = false;
            // 
            // CustomerPhone
            // 
            CustomerPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustomerPhone.HeaderText = "Customer Phone";
            CustomerPhone.MinimumWidth = 8;
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.ReadOnly = true;
            CustomerPhone.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // EmployeeId
            // 
            EmployeeId.HeaderText = "EmployeeId";
            EmployeeId.MinimumWidth = 8;
            EmployeeId.Name = "EmployeeId";
            EmployeeId.ReadOnly = true;
            EmployeeId.Visible = false;
            EmployeeId.Width = 150;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F);
            CreatedAt.DefaultCellStyle = dataGridViewCellStyle2;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            CreatedAt.Width = 300;
            CreatedAt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CreatedAt.DefaultCellStyle.Format = "dd/MM/yyyy";
            // 
            // delete
            // 
            delete.BackColor = Color.Crimson;
            delete.Font = new Font("Poppins", 12F);
            delete.ForeColor = Color.White;
            delete.Location = new Point(1020, 0);
            delete.Margin = new Padding(0);
            delete.Name = "delete";
            delete.Size = new Size(160, 49);
            delete.TabIndex = 22;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Poppins", 14F);
            SearchTextBox.Location = new Point(0, 0);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Search order";
            SearchTextBox.Size = new Size(533, 49);
            SearchTextBox.TabIndex = 21;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // CheckoutHistory
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(OrdersTable);
            Controls.Add(delete);
            Controls.Add(SearchTextBox);
            Margin = new Padding(0);
            Name = "CheckoutHistory";
            Size = new Size(1180, 905);
            ((System.ComponentModel.ISupportInitialize)OrdersTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrdersTable;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn CreatedAt;
        private Button delete;
        private TextBox SearchTextBox;
    }
}
