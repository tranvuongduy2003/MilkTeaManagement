namespace MilkTeaManagement.WindowsApp.Pages.Categories
{
    partial class CategoriesPage
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
            label1 = new Label();
            SearchTextBox = new TextBox();
            CategoriesComboBox = new ComboBox();
            CategoriesTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Poster = new DataGridViewTextBoxColumn();
            CreatorId = new DataGridViewTextBoxColumn();
            Creator = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(559, 70);
            label1.TabIndex = 3;
            label1.Text = "Categories Management";
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
            SearchTextBox.PlaceholderText = "   Search category";
            SearchTextBox.Size = new Size(533, 49);
            SearchTextBox.TabIndex = 12;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.Font = new Font("Poppins", 12F);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Items.AddRange(new object[] { "A to Z", "Z to A" });
            CategoriesComboBox.Location = new Point(573, 117);
            CategoriesComboBox.Margin = new Padding(0);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(182, 50);
            CategoriesComboBox.TabIndex = 13;
            CategoriesComboBox.Text = "  Sort by";
            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
            // 
            // CategoriesTable
            // 
            CategoriesTable.AllowUserToAddRows = false;
            CategoriesTable.AllowUserToDeleteRows = false;
            CategoriesTable.AllowUserToResizeColumns = false;
            CategoriesTable.AllowUserToResizeRows = false;
            CategoriesTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategoriesTable.ColumnHeadersHeight = 50;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { Id, CategoryName, Poster, CreatorId, Creator, CreatedAt });
            CategoriesTable.Location = new Point(30, 186);
            CategoriesTable.Margin = new Padding(0);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersWidth = 50;
            CategoriesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CategoriesTable.RowTemplate.Height = 50;
            CategoriesTable.Size = new Size(1760, 835);
            CategoriesTable.TabIndex = 16;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CategoryName.HeaderText = "Name";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "CategoryName";
            // 
            // Poster
            // 
            Poster.HeaderText = "Poster";
            Poster.MinimumWidth = 6;
            Poster.Name = "Poster";
            Poster.Visible = false;
            Poster.Width = 125;
            // 
            // CreatorId
            // 
            CreatorId.HeaderText = "CreatorId";
            CreatorId.MinimumWidth = 6;
            CreatorId.Name = "CreatorId";
            CreatorId.Visible = false;
            CreatorId.Width = 125;
            // 
            // Creator
            // 
            Creator.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Creator.HeaderText = "Creator";
            Creator.MinimumWidth = 8;
            Creator.Name = "Creator";
            Creator.Width = 500;
            // 
            // CreatedAt
            // 
            CreatedAt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 500;
            CategoriesTable.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Poppins", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1296, 117);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 49);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.Font = new Font("Poppins", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1467, 117);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 49);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.CornflowerBlue;
            btnCreate.Font = new Font("Poppins", 12F);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1636, 117);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(160, 49);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(CategoriesTable);
            Controls.Add(CategoriesComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "CategoriesPage";
            Size = new Size(1820, 1050);
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchTextBox;
        private ComboBox CategoriesComboBox;
        private DataGridView CategoriesTable;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Poster;
        private DataGridViewTextBoxColumn CreatorId;
        private DataGridViewTextBoxColumn Creator;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}
