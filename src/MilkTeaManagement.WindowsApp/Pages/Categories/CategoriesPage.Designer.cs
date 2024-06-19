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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new TextBox();
            CategoriesComboBox = new ComboBox();
            CategoriesTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Poster = new DataGridViewTextBoxColumn();
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
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 25);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(410, 39);
            label1.TabIndex = 3;
            label1.Text = "Categories Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Microsoft Sans Serif", 14F);
            SearchTextBox.Location = new Point(25, 98);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Search category";
            SearchTextBox.Size = new Size(444, 34);
            SearchTextBox.TabIndex = 12;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.Font = new Font("Microsoft Sans Serif", 12F);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Items.AddRange(new object[] { "A to Z", "Z to A" });
            CategoriesComboBox.Location = new Point(478, 98);
            CategoriesComboBox.Margin = new Padding(0);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(152, 33);
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategoriesTable.ColumnHeadersHeight = 50;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { Id, CategoryName, Poster, Creator, CreatedAt });
            CategoriesTable.Location = new Point(25, 155);
            CategoriesTable.Margin = new Padding(0);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersWidth = 62;
            CategoriesTable.RowTemplate.Height = 100;
            CategoriesTable.Size = new Size(1467, 696);
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            CategoryName.DefaultCellStyle = dataGridViewCellStyle2;
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
            // Creator
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            Creator.DefaultCellStyle = dataGridViewCellStyle3;
            Creator.HeaderText = "Creator";
            Creator.MinimumWidth = 8;
            Creator.Name = "Creator";
            Creator.Width = 400;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F);
            CreatedAt.DefaultCellStyle = dataGridViewCellStyle4;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 400;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1080, 98);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 41);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1222, 98);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 41);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.CornflowerBlue;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(1363, 98);
            btnCreate.Margin = new Padding(0);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(133, 41);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
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
            Size = new Size(1517, 875);
            ((System.ComponentModel.ISupportInitialize)CategoriesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchTextBox;
        private ComboBox CategoriesComboBox;
        private DataGridView CategoriesTable;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Poster;
        private DataGridViewTextBoxColumn Creator;
        private DataGridViewTextBoxColumn CreatedAt;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
    }
}
