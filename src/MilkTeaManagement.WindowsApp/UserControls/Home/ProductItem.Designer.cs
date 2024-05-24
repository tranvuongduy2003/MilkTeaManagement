namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    partial class ProductItem
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
            ProductImage = new PictureBox();
            ProductName = new Label();
            ProductDescription = new Label();
            ProductPrice = new Label();
            AddToBillButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductImage).BeginInit();
            SuspendLayout();
            // 
            // ProductImage
            // 
            ProductImage.BackgroundImage = Properties.Resources.product_image;
            ProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            ProductImage.Location = new Point(10, 10);
            ProductImage.Margin = new Padding(0);
            ProductImage.Name = "ProductImage";
            ProductImage.Size = new Size(180, 260);
            ProductImage.TabIndex = 0;
            ProductImage.TabStop = false;
            // 
            // ProductName
            // 
            ProductName.AllowDrop = true;
            ProductName.Font = new Font("Poppins Medium", 11F, FontStyle.Bold);
            ProductName.ForeColor = Color.White;
            ProductName.Location = new Point(200, 10);
            ProductName.Margin = new Padding(0);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(340, 76);
            ProductName.TabIndex = 1;
            ProductName.Text = "Macchiato Peper\nChocochip";
            // 
            // ProductDescription
            // 
            ProductDescription.AllowDrop = true;
            ProductDescription.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDescription.ForeColor = SystemColors.AppWorkspace;
            ProductDescription.Location = new Point(200, 86);
            ProductDescription.Margin = new Padding(0);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(340, 72);
            ProductDescription.TabIndex = 1;
            ProductDescription.Text = "Hot coffee with extract\nchocochip";
            // 
            // ProductPrice
            // 
            ProductPrice.AllowDrop = true;
            ProductPrice.AutoSize = true;
            ProductPrice.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.ForeColor = Color.White;
            ProductPrice.Location = new Point(200, 158);
            ProductPrice.Margin = new Padding(0);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(174, 42);
            ProductPrice.TabIndex = 1;
            ProductPrice.Text = "100,000 VNĐ";
            // 
            // AddToBillButton
            // 
            AddToBillButton.BackColor = SystemColors.AppWorkspace;
            AddToBillButton.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToBillButton.ForeColor = Color.White;
            AddToBillButton.Location = new Point(200, 203);
            AddToBillButton.Margin = new Padding(0);
            AddToBillButton.Name = "AddToBillButton";
            AddToBillButton.Size = new Size(340, 67);
            AddToBillButton.TabIndex = 2;
            AddToBillButton.Text = "Add to bill";
            AddToBillButton.UseVisualStyleBackColor = false;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(AddToBillButton);
            Controls.Add(ProductPrice);
            Controls.Add(ProductDescription);
            Controls.Add(ProductName);
            Controls.Add(ProductImage);
            Margin = new Padding(0, 0, 15, 15);
            Name = "ProductItem";
            Size = new Size(550, 280);
            ((System.ComponentModel.ISupportInitialize)ProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProductImage;
        private Label ProductName;
        private Label ProductDescription;
        private Label ProductPrice;
        private Button AddToBillButton;
    }
}
