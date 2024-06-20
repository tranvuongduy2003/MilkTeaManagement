namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Receiver
{
    partial class ReceiverVideoMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiverVideoMessage));
            Avatar = new Common.CircularPictureBox();
            Video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Video).BeginInit();
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
            Avatar.TabIndex = 2;
            Avatar.TabStop = false;
            // 
            // Video
            // 
            Video.Enabled = true;
            Video.Location = new Point(90, 0);
            Video.Margin = new Padding(0);
            Video.Name = "Video";
            Video.OcxState = (AxHost.State)resources.GetObject("Video.OcxState");
            Video.Size = new Size(400, 300);
            Video.TabIndex = 3;
            // 
            // ReceiverVideoMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Video);
            Controls.Add(Avatar);
            Margin = new Padding(0, 0, 0, 5);
            Name = "ReceiverVideoMessage";
            Size = new Size(1260, 300);
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Video).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Common.CircularPictureBox Avatar;
        private AxWMPLib.AxWindowsMediaPlayer Video;
    }
}
