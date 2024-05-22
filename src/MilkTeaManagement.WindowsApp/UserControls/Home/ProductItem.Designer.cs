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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.product_image;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 260);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Font = new Font("Poppins Medium", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 10);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(340, 76);
            label1.TabIndex = 1;
            label1.Text = "Macchiato Peper\nChocochip";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(200, 86);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(340, 72);
            label2.TabIndex = 1;
            label2.Text = "Hot coffee with extract\nchocochip";
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(200, 158);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(174, 42);
            label3.TabIndex = 1;
            label3.Text = "100,000 VNĐ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(200, 203);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(340, 67);
            button1.TabIndex = 2;
            button1.Text = "Add to bill";
            button1.UseVisualStyleBackColor = false;
            // 
            // ProductItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(0, 0, 15, 15);
            Name = "ProductItem";
            Size = new Size(550, 280);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
