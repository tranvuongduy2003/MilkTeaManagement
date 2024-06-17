namespace MilkTeaManagement.WindowsApp.Pages.Employees
{
    partial class EmployeesPage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            informationPanel = new Panel();
            panel2 = new Panel();
            create = new Button();
            SearchTextBox = new TextBox();
            label1 = new Label();
            EmployeesTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DOB = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesTable).BeginInit();
            SuspendLayout();
            // 
            // informationPanel
            // 
            informationPanel.Location = new Point(0, 0);
            informationPanel.Margin = new Padding(0);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(600, 1050);
            informationPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(create);
            panel2.Controls.Add(SearchTextBox);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(EmployeesTable);
            panel2.Location = new Point(600, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 1050);
            panel2.TabIndex = 1;
            // 
            // create
            // 
            create.BackColor = Color.CornflowerBlue;
            create.Font = new Font("Poppins", 12F);
            create.ForeColor = Color.White;
            create.Location = new Point(1040, 121);
            create.Margin = new Padding(0);
            create.Name = "create";
            create.Size = new Size(160, 49);
            create.TabIndex = 17;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Poppins", 14F);
            SearchTextBox.Location = new Point(20, 121);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Search employee";
            SearchTextBox.Size = new Size(533, 49);
            SearchTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(556, 70);
            label1.TabIndex = 15;
            label1.Text = "Employees Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeesTable
            // 
            EmployeesTable.AllowUserToAddRows = false;
            EmployeesTable.AllowUserToDeleteRows = false;
            EmployeesTable.AllowUserToResizeColumns = false;
            EmployeesTable.AllowUserToResizeRows = false;
            EmployeesTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmployeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmployeesTable.ColumnHeadersHeight = 50;
            EmployeesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            EmployeesTable.Columns.AddRange(new DataGridViewColumn[] { Id, UserName, FullName, Email, PhoneNumber, Gender, DOB, Status, Role });
            EmployeesTable.Location = new Point(20, 190);
            EmployeesTable.Margin = new Padding(0);
            EmployeesTable.Name = "EmployeesTable";
            EmployeesTable.ReadOnly = true;
            EmployeesTable.RowHeadersWidth = 50;
            EmployeesTable.RowTemplate.Height = 50;
            EmployeesTable.Size = new Size(1180, 835);
            EmployeesTable.TabIndex = 14;
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
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F);
            UserName.DefaultCellStyle = dataGridViewCellStyle2;
            UserName.HeaderText = "Username";
            UserName.MinimumWidth = 8;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Visible = false;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.HeaderText = "Fullname";
            FullName.MinimumWidth = 8;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 320;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 250;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 8;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.Visible = false;
            Gender.Width = 150;
            // 
            // DOB
            // 
            DOB.HeaderText = "Birthday";
            DOB.MinimumWidth = 8;
            DOB.Name = "DOB";
            DOB.ReadOnly = true;
            DOB.Visible = false;
            DOB.Width = 250;
            // 
            // Status
            // 
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F);
            Status.DefaultCellStyle = dataGridViewCellStyle3;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            Status.Width = 200;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.ReadOnly = true;
            Role.Width = 150;
            // 
            // EmployeesPage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(panel2);
            Controls.Add(informationPanel);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "EmployeesPage";
            Size = new Size(1820, 1050);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel informationPanel;
        private Panel panel2;
        private DataGridView EmployeesTable;
        private Label label1;
        private TextBox SearchTextBox;
        private Button create;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Role;
    }
}
