namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Receiver
{
    partial class ReceiverImageMessage
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
            Avatar = new Common.CircularPictureBox();
            Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.White;
            Avatar.BackgroundImage = Properties.Resources.avatar;
            Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar.Location = new Point(20, 0);
            Avatar.Margin = new Padding(0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(45, 45);
            Avatar.TabIndex = 3;
            Avatar.TabStop = false;
            // 
            // Image
            // 
            Image.BackColor = Color.White;
            Image.BackgroundImageLayout = ImageLayout.Zoom;
            Image.Location = new Point(90, 0);
            Image.Margin = new Padding(0);
            Image.Name = "Image";
            Image.Size = new Size(400, 300);
            Image.TabIndex = 4;
            Image.TabStop = false;
            // 
            // ReceiverImageMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Image);
            Controls.Add(Avatar);
            Margin = new Padding(0, 0, 0, 5);
            Name = "ReceiverImageMessage";
            Size = new Size(1260, 300);
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Common.CircularPictureBox Avatar;
        private PictureBox Image;
    }
}
