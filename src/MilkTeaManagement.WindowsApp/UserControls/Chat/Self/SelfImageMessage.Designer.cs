namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Self
{
    partial class SelfImageMessage
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
            Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // Image
            // 
            Image.BackColor = Color.White;
            Image.BackgroundImageLayout = ImageLayout.Zoom;
            Image.Location = new Point(840, 0);
            Image.Margin = new Padding(0, 0, 0, 5);
            Image.Name = "Image";
            Image.Size = new Size(400, 300);
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // SelfImageMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Image);
            Margin = new Padding(0);
            Name = "SelfImageMessage";
            Size = new Size(1260, 300);
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Image;
    }
}
