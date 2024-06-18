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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new TextBox();
            CategoriesComboBox = new ComboBox();
            create = new Button();
            CategoriesTable = new DataGridView();
            Poster = new DataGridViewImageColumn();
            CategoryName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            Creator = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
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
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.Font = new Font("Microsoft Sans Serif", 12F);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Location = new Point(478, 98);
            CategoriesComboBox.Margin = new Padding(0);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(152, 33);
            CategoriesComboBox.TabIndex = 13;
            CategoriesComboBox.Text = "  Category";
            // 
            // create
            // 
            create.BackColor = Color.CornflowerBlue;
            create.Font = new Font("Microsoft Sans Serif", 12F);
            create.ForeColor = Color.White;
            create.Location = new Point(1198, 98);
            create.Margin = new Padding(0);
            create.Name = "create";
            create.Size = new Size(293, 41);
            create.TabIndex = 15;
            create.Text = "Create new category";
            create.UseVisualStyleBackColor = false;
            // 
            // CategoriesTable
            // 
            CategoriesTable.AllowUserToAddRows = false;
            CategoriesTable.AllowUserToDeleteRows = false;
            CategoriesTable.AllowUserToResizeColumns = false;
            CategoriesTable.AllowUserToResizeRows = false;
            CategoriesTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CategoriesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CategoriesTable.ColumnHeadersHeight = 50;
            CategoriesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CategoriesTable.Columns.AddRange(new DataGridViewColumn[] { Poster, CategoryName, Quantity, CreatedAt, Creator, Action });
            CategoriesTable.Location = new Point(25, 155);
            CategoriesTable.Margin = new Padding(0);
            CategoriesTable.Name = "CategoriesTable";
            CategoriesTable.RowHeadersWidth = 62;
            CategoriesTable.RowTemplate.Height = 100;
            CategoriesTable.Size = new Size(1467, 696);
            CategoriesTable.TabIndex = 16;
            // 
            // Poster
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle2.NullValue = null;
            Poster.DefaultCellStyle = dataGridViewCellStyle2;
            Poster.HeaderText = "Category";
            Poster.MinimumWidth = 8;
            Poster.Name = "Poster";
            Poster.Resizable = DataGridViewTriState.True;
            Poster.SortMode = DataGridViewColumnSortMode.Automatic;
            Poster.Width = 300;
            // 
            // CategoryName
            // 
            CategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
            CategoryName.DefaultCellStyle = dataGridViewCellStyle3;
            CategoryName.HeaderText = "Name";
            CategoryName.MinimumWidth = 8;
            CategoryName.Name = "CategoryName";
            // 
            // Quantity
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F);
            Quantity.DefaultCellStyle = dataGridViewCellStyle4;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 200;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F);
            CreatedAt.DefaultCellStyle = dataGridViewCellStyle5;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 150;
            // 
            // Creator
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F);
            Creator.DefaultCellStyle = dataGridViewCellStyle6;
            Creator.HeaderText = "Creator";
            Creator.MinimumWidth = 8;
            Creator.Name = "Creator";
            Creator.Width = 200;
            // 
            // Action
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F);
            Action.DefaultCellStyle = dataGridViewCellStyle7;
            Action.HeaderText = "Action";
            Action.MinimumWidth = 8;
            Action.Name = "Action";
            Action.Width = 150;
            // 
            // CategoriesPage
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(CategoriesTable);
            Controls.Add(create);
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
        private Button create;
        private DataGridView CategoriesTable;
        private DataGridViewImageColumn Poster;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn Creator;
        private DataGridViewTextBoxColumn Action;
    }
}
