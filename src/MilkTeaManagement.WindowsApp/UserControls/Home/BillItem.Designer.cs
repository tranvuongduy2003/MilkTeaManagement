namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    partial class BillItem
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
            poster = new PictureBox();
            name = new Label();
            price = new Label();
            decrease = new Button();
            increase = new Button();
            quantity = new TextBox();
            subTotal = new Label();
            description = new TextBox();
            remove = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)poster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)remove).BeginInit();
            SuspendLayout();
            // 
            // poster
            // 
            poster.BackColor = Color.Transparent;
            poster.BackgroundImage = Properties.Resources.product_image1;
            poster.BackgroundImageLayout = ImageLayout.Zoom;
            poster.Location = new Point(0, 0);
            poster.Margin = new Padding(0);
            poster.Name = "poster";
            poster.Size = new Size(70, 70);
            poster.TabIndex = 0;
            poster.TabStop = false;
            // 
            // name
            // 
            name.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.White;
            name.Location = new Point(80, 0);
            name.Margin = new Padding(0);
            name.Name = "name";
            name.Size = new Size(450, 38);
            name.TabIndex = 1;
            name.Text = "Americano Passion Coffee";
            // 
            // price
            // 
            price.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.ForeColor = Color.WhiteSmoke;
            price.Location = new Point(80, 38);
            price.Margin = new Padding(0);
            price.Name = "price";
            price.Size = new Size(450, 32);
            price.TabIndex = 1;
            price.Text = "200,000 VNĐ";
            // 
            // decrease
            // 
            decrease.BackColor = Color.White;
            decrease.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decrease.ForeColor = Color.FromArgb(64, 64, 64);
            decrease.Location = new Point(0, 80);
            decrease.Margin = new Padding(0);
            decrease.Name = "decrease";
            decrease.Size = new Size(40, 40);
            decrease.TabIndex = 2;
            decrease.Text = "-";
            decrease.UseVisualStyleBackColor = false;
            decrease.Click += decrease_Click;
            // 
            // increase
            // 
            increase.BackColor = Color.White;
            increase.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            increase.ForeColor = Color.FromArgb(64, 64, 64);
            increase.Location = new Point(160, 80);
            increase.Margin = new Padding(0);
            increase.Name = "increase";
            increase.Size = new Size(40, 40);
            increase.TabIndex = 3;
            increase.Text = "+";
            increase.UseVisualStyleBackColor = false;
            increase.Click += increase_Click;
            // 
            // quantity
            // 
            quantity.BackColor = Color.Silver;
            quantity.BorderStyle = BorderStyle.None;
            quantity.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantity.ForeColor = Color.White;
            quantity.Location = new Point(50, 81);
            quantity.Margin = new Padding(0);
            quantity.Name = "quantity";
            quantity.Size = new Size(100, 36);
            quantity.TabIndex = 4;
            quantity.TextAlign = HorizontalAlignment.Center;
            // 
            // subTotal
            // 
            subTotal.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.WhiteSmoke;
            subTotal.Location = new Point(203, 81);
            subTotal.Margin = new Padding(0);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(327, 38);
            subTotal.TabIndex = 5;
            subTotal.Text = "2,000,000 VNĐ";
            subTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // description
            // 
            description.BackColor = Color.Silver;
            description.BorderStyle = BorderStyle.FixedSingle;
            description.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.ForeColor = Color.White;
            description.Location = new Point(0, 130);
            description.Margin = new Padding(0);
            description.Name = "description";
            description.PlaceholderText = "   Note...";
            description.Size = new Size(470, 49);
            description.TabIndex = 6;
            description.TextChanged += description_TextChanged;
            // 
            // remove
            // 
            remove.BackColor = Color.Red;
            remove.BackgroundImage = Properties.Resources.bin2;
            remove.BackgroundImageLayout = ImageLayout.Center;
            remove.Location = new Point(480, 130);
            remove.Margin = new Padding(0);
            remove.Name = "remove";
            remove.Size = new Size(50, 50);
            remove.TabIndex = 7;
            remove.TabStop = false;
            remove.Click += remove_Click;
            // 
            // BillItem
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(remove);
            Controls.Add(description);
            Controls.Add(subTotal);
            Controls.Add(quantity);
            Controls.Add(increase);
            Controls.Add(decrease);
            Controls.Add(price);
            Controls.Add(name);
            Controls.Add(poster);
            Margin = new Padding(0, 0, 0, 20);
            Name = "BillItem";
            Size = new Size(530, 180);
            ((System.ComponentModel.ISupportInitialize)poster).EndInit();
            ((System.ComponentModel.ISupportInitialize)remove).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox poster;
        private Label name;
        private Label price;
        private Button decrease;
        private Button increase;
        private TextBox quantity;
        private Label subTotal;
        private TextBox description;
        private PictureBox remove;
    }
}
