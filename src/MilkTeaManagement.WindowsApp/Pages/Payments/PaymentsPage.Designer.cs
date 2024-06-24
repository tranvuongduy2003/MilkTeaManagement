namespace MilkTeaManagement.WindowsApp.Pages.Payments
{
    partial class PaymentsPage
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new TextBox();
            PaymentsTable = new DataGridView();
            delete = new Button();
            Id = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            CustomerPhone = new DataGridViewTextBoxColumn();
            EmployeeId = new DataGridViewTextBoxColumn();
            EmployeeName = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)PaymentsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(537, 70);
            label1.TabIndex = 2;
            label1.Text = "Payments Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Poppins", 14F);
            SearchTextBox.Location = new Point(30, 117);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Search ";
            SearchTextBox.Size = new Size(533, 49);
            SearchTextBox.TabIndex = 11;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // PaymentsTable
            // 
            PaymentsTable.AllowUserToAddRows = false;
            PaymentsTable.AllowUserToDeleteRows = false;
            PaymentsTable.AllowUserToResizeColumns = false;
            PaymentsTable.AllowUserToResizeRows = false;
            PaymentsTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            PaymentsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            PaymentsTable.ColumnHeadersHeight = 50;
            PaymentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            PaymentsTable.Columns.AddRange(new DataGridViewColumn[] { Id, TotalPrice, Discount, CustomerPhone, EmployeeId, EmployeeName, CreatedAt });
            PaymentsTable.Location = new Point(30, 186);
            PaymentsTable.Margin = new Padding(0);
            PaymentsTable.Name = "PaymentsTable";
            PaymentsTable.ReadOnly = true;
            PaymentsTable.RowHeadersWidth = 50;
            PaymentsTable.RowTemplate.Height = 50;
            PaymentsTable.Size = new Size(1760, 835);
            PaymentsTable.TabIndex = 13;
            // 
            // delete
            // 
            delete.BackColor = Color.Crimson;
            delete.Font = new Font("Poppins", 12F);
            delete.ForeColor = Color.White;
            delete.Location = new Point(1630, 117);
            delete.Margin = new Padding(0);
            delete.Name = "delete";
            delete.Size = new Size(160, 49);
            delete.TabIndex = 16;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
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
            Discount.Visible = false;
            Discount.Width = 250;
            // 
            // CustomerPhone
            // 
            CustomerPhone.HeaderText = "Customer Phone";
            CustomerPhone.MinimumWidth = 8;
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.ReadOnly = true;
            CustomerPhone.Width = 300;
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
            // EmployeeName
            // 
            EmployeeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F);
            EmployeeName.DefaultCellStyle = dataGridViewCellStyle5;
            EmployeeName.HeaderText = "Checkout Person";
            EmployeeName.MinimumWidth = 8;
            EmployeeName.Name = "EmployeeName";
            EmployeeName.ReadOnly = true;
            EmployeeName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Poppins", 9F);
            CreatedAt.DefaultCellStyle = dataGridViewCellStyle6;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            CreatedAt.Width = 400;
            CreatedAt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PaymentsTable.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            // 
            // PaymentsPage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(delete);
            Controls.Add(PaymentsTable);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "PaymentsPage";
            Size = new Size(1820, 1050);
            ((System.ComponentModel.ISupportInitialize)PaymentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox SearchTextBox;
        private DataGridView PaymentsTable;
        private Button delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn EmployeeId;
        private DataGridViewTextBoxColumn EmployeeName;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}
