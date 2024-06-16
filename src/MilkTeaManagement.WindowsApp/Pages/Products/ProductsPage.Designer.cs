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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            SearchTextBox = new TextBox();
            CategoriesComboBox = new ComboBox();
            ProductsTable = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ProductCategoryId = new DataGridViewTextBoxColumn();
            Poster = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            create = new Button();
            update = new Button();
            delete = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProductsTable.ColumnHeadersHeight = 50;
            ProductsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ProductsTable.Columns.AddRange(new DataGridViewColumn[] { Id, ProductPrice, Description, ProductCategoryId, Poster, ProductName, Status, Category, Price, CreatedAt });
            ProductsTable.Location = new Point(30, 186);
            ProductsTable.Margin = new Padding(0);
            ProductsTable.Name = "ProductsTable";
            ProductsTable.ReadOnly = true;
            ProductsTable.RowHeadersWidth = 50;
            ProductsTable.RowTemplate.Height = 50;
            ProductsTable.Size = new Size(1760, 835);
            ProductsTable.TabIndex = 13;
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
            // ProductPrice
            // 
            ProductPrice.HeaderText = "ProductPrice";
            ProductPrice.MinimumWidth = 8;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            ProductPrice.Visible = false;
            ProductPrice.Width = 150;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 8;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Visible = false;
            Description.Width = 150;
            // 
            // ProductCategoryId
            // 
            ProductCategoryId.HeaderText = "ProductCategoryId";
            ProductCategoryId.MinimumWidth = 8;
            ProductCategoryId.Name = "ProductCategoryId";
            ProductCategoryId.ReadOnly = true;
            ProductCategoryId.Visible = false;
            ProductCategoryId.Width = 150;
            // 
            // Poster
            // 
            Poster.HeaderText = "Poster";
            Poster.MinimumWidth = 8;
            Poster.Name = "Poster";
            Poster.ReadOnly = true;
            Poster.Visible = false;
            Poster.Width = 150;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F);
            ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F);
            Status.DefaultCellStyle = dataGridViewCellStyle3;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 200;
            // 
            // Category
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new Font("Poppins", 9F);
            Category.DefaultCellStyle = dataGridViewCellStyle4;
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 250;
            // 
            // Price
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new Font("Poppins", 9F);
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 200;
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
            CreatedAt.Width = 350;
            // 
            // create
            // 
            create.BackColor = Color.CornflowerBlue;
            create.Font = new Font("Poppins", 12F);
            create.ForeColor = Color.White;
            create.Location = new Point(1636, 117);
            create.Margin = new Padding(0);
            create.Name = "create";
            create.Size = new Size(160, 49);
            create.TabIndex = 14;
            create.Text = "Create";
            create.UseVisualStyleBackColor = false;
            create.Click += create_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(192, 192, 0);
            update.Font = new Font("Poppins", 12F);
            update.ForeColor = Color.White;
            update.Location = new Point(1467, 117);
            update.Margin = new Padding(0);
            update.Name = "update";
            update.Size = new Size(160, 49);
            update.TabIndex = 15;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Crimson;
            delete.Font = new Font("Poppins", 12F);
            delete.ForeColor = Color.White;
            delete.Location = new Point(1296, 117);
            delete.Margin = new Padding(0);
            delete.Name = "delete";
            delete.Size = new Size(160, 49);
            delete.TabIndex = 16;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // ProductsPage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(delete);
            Controls.Add(update);
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
        private Button create;
        private Button update;
        private Button delete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ProductCategoryId;
        private DataGridViewTextBoxColumn Poster;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CreatedAt;
    }
}