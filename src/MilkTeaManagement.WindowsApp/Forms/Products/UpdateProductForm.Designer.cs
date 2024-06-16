using Microsoft.AspNetCore.Http.HttpResults;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace MilkTeaManagement.WindowsApp.Forms.Products
{
    partial class UpdateProductForm
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
            Poster = new PictureBox();
            label2 = new Label();
            NameTextbox = new TextBox();
            PriceTextbox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            CategoriesComboBox = new ComboBox();
            label5 = new Label();
            DescriptionTextbox = new RichTextBox();
            label6 = new Label();
            Update = new Button();
            delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Poster).BeginInit();
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
            // Poster
            // 
            Poster.BackColor = Color.White;
            Poster.BackgroundImage = Properties.Resources.upload_image1;
            Poster.BackgroundImageLayout = ImageLayout.Zoom;
            Poster.Location = new Point(36, 208);
            Poster.Name = "Poster";
            Poster.Size = new Size(324, 461);
            Poster.TabIndex = 3;
            Poster.TabStop = false;
            Poster.Click += poster_Click;
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
            // NameTextbox
            // 
            NameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTextbox.BorderStyle = BorderStyle.FixedSingle;
            NameTextbox.Font = new Font("Poppins", 11F);
            NameTextbox.Location = new Point(398, 195);
            NameTextbox.Margin = new Padding(0);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.PlaceholderText = "   Product name";
            NameTextbox.Size = new Size(587, 40);
            NameTextbox.TabIndex = 12;
            // 
            // PriceTextbox
            // 
            PriceTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceTextbox.BorderStyle = BorderStyle.FixedSingle;
            PriceTextbox.Font = new Font("Poppins", 11F);
            PriceTextbox.Location = new Point(398, 295);
            PriceTextbox.Margin = new Padding(0);
            PriceTextbox.Name = "PriceTextbox";
            PriceTextbox.PlaceholderText = "   Product price";
            PriceTextbox.Size = new Size(587, 40);
            PriceTextbox.TabIndex = 14;
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
            CategoriesComboBox.SelectedIndexChanged += CategoriesComboBox_SelectedIndexChanged;
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
            // DescriptionTextbox
            // 
            DescriptionTextbox.Font = new Font("Poppins", 10F);
            DescriptionTextbox.Location = new Point(398, 498);
            DescriptionTextbox.Margin = new Padding(0);
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(587, 171);
            DescriptionTextbox.TabIndex = 18;
            DescriptionTextbox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 55);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(461, 70);
            label6.TabIndex = 19;
            label6.Text = "Update New Product";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.BackColor = Color.FromArgb(192, 192, 0);
            Update.Font = new Font("Poppins", 12F);
            Update.ForeColor = Color.White;
            Update.Location = new Point(605, 700);
            Update.Margin = new Padding(0);
            Update.Name = "Update";
            Update.Size = new Size(380, 52);
            Update.TabIndex = 20;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += create_Click;
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.BackColor = Color.Crimson;
            delete.Font = new Font("Poppins", 12F);
            delete.ForeColor = Color.White;
            delete.Location = new Point(36, 700);
            delete.Margin = new Padding(0);
            delete.Name = "delete";
            delete.Size = new Size(380, 52);
            delete.TabIndex = 21;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1024, 788);
            Controls.Add(delete);
            Controls.Add(Update);
            Controls.Add(label6);
            Controls.Add(DescriptionTextbox);
            Controls.Add(label5);
            Controls.Add(CategoriesComboBox);
            Controls.Add(label4);
            Controls.Add(PriceTextbox);
            Controls.Add(label3);
            Controls.Add(NameTextbox);
            Controls.Add(label2);
            Controls.Add(Poster);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateProductForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private PictureBox closeButton;
        private Label label1;
        private PictureBox Poster;
        private Label label2;
        private TextBox NameTextbox;
        private TextBox PriceTextbox;
        private Label label3;
        private Label label4;
        private ComboBox CategoriesComboBox;
        private Label label5;
        private RichTextBox DescriptionTextbox;
        private Label label6;
        private Button Update;
        private Button delete;
    }
}