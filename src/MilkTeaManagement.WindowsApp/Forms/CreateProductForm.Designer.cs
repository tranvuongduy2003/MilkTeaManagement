namespace MilkTeaManagement.WindowsApp.Forms
{
    partial class CreateProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            closeButton = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            SearchTextBox = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CategoriesComboBox = new ComboBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 30);
            panel1.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImage = Properties.Resources.multiply;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Location = new Point(994, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 13;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(79, 673);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Transparent;
            close.BackgroundImage = Properties.Resources.multiply;
            close.BackgroundImageLayout = ImageLayout.Stretch;
            close.Location = new Point(1890, 0);
            close.Margin = new Padding(0);
            close.Name = "close";
            close.Size = new Size(30, 30);
            close.TabIndex = 12;
            close.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 156);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(90, 39);
            label1.TabIndex = 2;
            label1.Text = "Poster:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 461);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(398, 156);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(89, 39);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Poppins", 11F);
            SearchTextBox.Location = new Point(398, 195);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "   Product name";
            SearchTextBox.Size = new Size(587, 40);
            SearchTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Poppins", 11F);
            textBox1.Location = new Point(398, 295);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "   Product price";
            textBox1.Size = new Size(587, 40);
            textBox1.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(398, 256);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(75, 39);
            label3.TabIndex = 13;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(398, 356);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(125, 39);
            label4.TabIndex = 15;
            label4.Text = "Category:";
            // 
            // CategoriesComboBox
            // 
            CategoriesComboBox.Font = new Font("Poppins", 10F);
            CategoriesComboBox.FormattingEnabled = true;
            CategoriesComboBox.Location = new Point(398, 395);
            CategoriesComboBox.Margin = new Padding(0);
            CategoriesComboBox.Name = "CategoriesComboBox";
            CategoriesComboBox.Size = new Size(587, 44);
            CategoriesComboBox.TabIndex = 16;
            CategoriesComboBox.Text = "  Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(398, 456);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(145, 39);
            label5.TabIndex = 17;
            label5.Text = "Description:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Poppins", 10F);
            richTextBox1.Location = new Point(398, 498);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(587, 171);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 55);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(450, 70);
            label6.TabIndex = 19;
            label6.Text = "Create New Product";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CreateProductForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1024, 709);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(CategoriesComboBox);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(SearchTextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateProductForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private PictureBox closeButton;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox SearchTextBox;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox CategoriesComboBox;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
    }
}