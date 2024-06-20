namespace MilkTeaManagement.WindowsApp.UserControls.Chat.Self
{
    partial class SelfVideoMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelfVideoMessage));
            Video = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)Video).BeginInit();
            SuspendLayout();
            // 
            // Video
            // 
            Video.Enabled = true;
            Video.Location = new Point(840, 0);
            Video.Margin = new Padding(0);
            Video.Name = "Video";
            Video.OcxState = (AxHost.State)resources.GetObject("Video.OcxState");
            Video.Size = new Size(400, 300);
            Video.TabIndex = 0;
            // 
            // SelfVideoMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Video);
            Margin = new Padding(0, 0, 0, 5);
            Name = "SelfVideoMessage";
            Size = new Size(1260, 300);
            ((System.ComponentModel.ISupportInitialize)Video).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Video;
    }
}
