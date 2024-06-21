namespace MilkTeaManagement.WindowsApp.Forms.Categories
{
    partial class UpdateCategoryForm
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
            btnClose = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new PictureBox();
            label6 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            Poster = new PictureBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Poster).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.multiply;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.Location = new Point(994, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 13;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 30);
            panel1.TabIndex = 3;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 55);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(393, 70);
            label6.TabIndex = 21;
            label6.Text = "Update Category";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbName.BorderStyle = BorderStyle.FixedSingle;
            tbName.Font = new Font("Poppins", 11F);
            tbName.Location = new Point(398, 208);
            tbName.Margin = new Padding(0);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "   Category name";
            tbName.Size = new Size(588, 40);
            tbName.TabIndex = 28;
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
            label2.TabIndex = 27;
            label2.Text = "Name:";
            // 
            // Poster
            // 
            Poster.BackColor = Color.White;
            Poster.BackgroundImageLayout = ImageLayout.Zoom;
            Poster.Location = new Point(36, 208);
            Poster.Margin = new Padding(2);
            Poster.Name = "Poster";
            Poster.Size = new Size(324, 461);
            Poster.TabIndex = 26;
            Poster.TabStop = false;
            Poster.Click += Poster_Click;
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
            label1.TabIndex = 25;
            label1.Text = "Poster:";
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Poppins", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(504, 617);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(380, 52);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdate.Font = new Font("Poppins", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(504, 516);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(380, 52);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateCategoryForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1024, 720);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(Poster);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "UpdateCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateCategoryForm";
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnClose;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private Label label6;
        private TextBox tbName;
        private Label label2;
        private PictureBox Poster;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
    }
}