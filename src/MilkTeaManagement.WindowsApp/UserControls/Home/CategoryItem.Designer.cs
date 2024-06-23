namespace MilkTeaManagement.WindowsApp.UserControls.Home
{
    partial class CategoryItem
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
            CategoryImage = new PictureBox();
            CategoryName = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryImage).BeginInit();
            SuspendLayout();
            // 
            // CategoryImage
            // 
            CategoryImage.BackgroundImage = Properties.Resources.coke;
            CategoryImage.BackgroundImageLayout = ImageLayout.Zoom;
            CategoryImage.Location = new Point(25, 25);
            CategoryImage.Margin = new Padding(0);
            CategoryImage.Name = "CategoryImage";
            CategoryImage.Size = new Size(100, 100);
            CategoryImage.TabIndex = 0;
            CategoryImage.TabStop = false;
            // 
            // CategoryName
            // 
            CategoryName.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoryName.ForeColor = Color.White;
            CategoryName.Location = new Point(0, 135);
            CategoryName.Margin = new Padding(0);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(150, 40);
            CategoryName.TabIndex = 1;
            CategoryName.Text = "Baverage";
            CategoryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CategoryItem
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(CategoryName);
            Controls.Add(CategoryImage);
            Margin = new Padding(0, 0, 10, 0);
            Name = "CategoryItem";
            Size = new Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)CategoryImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox CategoryImage;
        private Label CategoryName;
    }
}
