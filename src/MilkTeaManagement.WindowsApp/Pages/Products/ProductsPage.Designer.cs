namespace MilkTeaManagement.WindowsApp.Pages.Products
{
    partial class ProductsPage
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new TextBox();
            CategoriesComboBox = new ComboBox();
            ProductsTable = new DataGridView();
            Poster = new DataGridViewImageColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            Creator = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            create = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsTable).BeginInit();
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
            label1.Size = new Size(512, 70);
            label1.TabIndex = 2;
            label1.Text = "Products Management";
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
            SearchTextBox.PlaceholderText = "   Search food";
            SearchTextBox.Size = new Size(533, 49);
            SearchTextBox.TabIndex = 11;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.Font = new Font("Poppins", 12F);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Location = new Point(573, 117);
            CategoriesComboBox.Margin = new Padding(0);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(182, 50);
            CategoriesComboBox.TabIndex = 12;
            CategoriesComboBox.Text = "  Category";
            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
            // 
            // ProductsTable
            // 
            ProductsTable.AllowUserToAddRows = false;
            ProductsTable.AllowUserToDeleteRows = false;
            ProductsTable.AllowUserToResizeColumns = false;
            ProductsTable.AllowUserToResizeRows = false;
            ProductsTable.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            ProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            ProductsTable.ColumnHeadersHeight = 50;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { Poster, ProductName, Status, Category, Price, CreatedAt, Creator, Action });
            ProductsTable.Location = new Point(30, 186);
            ProductsTable.Margin = new Padding(0);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.RowHeadersWidth = 62;
            ProductsTable.RowTemplate.Height = 100;
            ProductsTable.Size = new Size(1760, 835);
            ProductsTable.TabIndex = 13;
            // 
            // Poster
            // 
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new Font("Poppins", 20F);
            dataGridViewCellStyle20.NullValue = null;
            Poster.DefaultCellStyle = dataGridViewCellStyle20;
            Poster.HeaderText = "Product";
            Poster.MinimumWidth = 8;
            Poster.Name = "Poster";
            Poster.Resizable = DataGridViewTriState.True;
            Poster.SortMode = DataGridViewColumnSortMode.Automatic;
            Poster.Width = 300;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.Font = new Font("Poppins", 9F);
            ProductName.DefaultCellStyle = dataGridViewCellStyle21;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            // 
            // Status
            // 
            dataGridViewCellStyle22.Font = new Font("Poppins", 9F);
            Status.DefaultCellStyle = dataGridViewCellStyle22;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // Category
            // 
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.Font = new Font("Poppins", 9F);
            Category.DefaultCellStyle = dataGridViewCellStyle23;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.Width = 200;
            // 
            // Price
            // 
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.Font = new Font("Poppins", 9F);
            Price.DefaultCellStyle = dataGridViewCellStyle24;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 200;
            // 
            // CreatedAt
            // 
            dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.Font = new Font("Poppins", 9F);
            CreatedAt.DefaultCellStyle = dataGridViewCellStyle25;
            CreatedAt.HeaderText = "Created At";
            CreatedAt.MinimumWidth = 8;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 150;
            // 
            // Creator
            // 
            dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.Font = new Font("Poppins", 9F);
            Creator.DefaultCellStyle = dataGridViewCellStyle26;
            Creator.HeaderText = "Creator";
            Creator.MinimumWidth = 8;
            Creator.Name = "Creator";
            Creator.Width = 200;
            // 
            // Action
            // 
            dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new Font("Poppins", 9F);
            Action.DefaultCellStyle = dataGridViewCellStyle27;
            Action.HeaderText = "Action";
            Action.MinimumWidth = 8;
            Action.Name = "Action";
            Action.Width = 150;
            // 
            // create
            // 
            create.BackColor = Color.CornflowerBlue;
            create.Font = new Font("Poppins", 12F);
            create.ForeColor = Color.White;
            create.Location = new Point(1438, 117);
            create.Margin = new Padding(0);
            create.Name = "create";
            create.Size = new Size(352, 49);
            create.TabIndex = 14;
            create.Text = "Create new product";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // ProductsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(create);
            Controls.Add(ProductsTable);
            Controls.Add(CategoriesComboBox);
            Controls.Add(SearchTextBox);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "ProductsPage";
            Size = new Size(1820, 1050);
            ((System.ComponentModel.ISupportInitialize)ProductsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox SearchTextBox;
        private ComboBox CategoriesComboBox;
        private DataGridView ProductsTable;
        private DataGridViewImageColumn Poster;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn Creator;
        private DataGridViewTextBoxColumn Action;
        private Button create;
    }
}
