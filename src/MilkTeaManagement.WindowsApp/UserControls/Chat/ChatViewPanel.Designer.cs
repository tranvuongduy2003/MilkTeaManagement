namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    partial class ChatViewPanel
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
            panel1 = new Panel();
            Role = new Label();
            FullName = new Label();
            Avatar = new Common.CircularPictureBox();
            panel2 = new Panel();
            Send = new PictureBox();
            Content = new TextBox();
            MessagesPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Send).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(Role);
            panel1.Controls.Add(FullName);
            panel1.Controls.Add(Avatar);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 100);
            panel1.TabIndex = 0;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role.Location = new Point(120, 51);
            Role.Margin = new Padding(0);
            Role.Name = "Role";
            Role.Size = new Size(89, 39);
            Role.TabIndex = 1;
            Role.Text = "Admin";
            // 
            // FullName
            // 
            FullName.AutoSize = true;
            FullName.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FullName.Location = new Point(120, 10);
            FullName.Margin = new Padding(0);
            FullName.Name = "FullName";
            FullName.Size = new Size(103, 42);
            FullName.TabIndex = 1;
            FullName.Text = "Admin";
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.White;
            Avatar.BackgroundImage = Properties.Resources.avatar;
            Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar.Location = new Point(20, 10);
            Avatar.Margin = new Padding(0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(80, 80);
            Avatar.TabIndex = 0;
            Avatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(Send);
            panel2.Controls.Add(Content);
            panel2.Location = new Point(0, 950);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1290, 100);
            panel2.TabIndex = 2;
            // 
            // Send
            // 
            Send.BackgroundImage = Properties.Resources.send_icon2;
            Send.BackgroundImageLayout = ImageLayout.Stretch;
            Send.Location = new Point(1227, 33);
            Send.Margin = new Padding(0);
            Send.Name = "Send";
            Send.Size = new Size(34, 34);
            Send.TabIndex = 1;
            Send.TabStop = false;
            Send.Click += Send_Click;
            // 
            // Content
            // 
            Content.Font = new Font("Poppins", 9F);
            Content.Location = new Point(187, 33);
            Content.Margin = new Padding(0);
            Content.MaxLength = 10000;
            Content.Name = "Content";
            Content.Size = new Size(1022, 34);
            Content.TabIndex = 0;
            // 
            // MessagesPanel
            // 
            MessagesPanel.AutoScroll = true;
            MessagesPanel.BackColor = Color.White;
            MessagesPanel.Location = new Point(0, 100);
            MessagesPanel.Margin = new Padding(0);
            MessagesPanel.Name = "MessagesPanel";
            MessagesPanel.Size = new Size(1290, 850);
            MessagesPanel.TabIndex = 3;
            // 
            // ChatViewPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MessagesPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ChatViewPanel";
            Size = new Size(1290, 1050);
            Load += ChatViewPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Send).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label FullName;
        private Common.CircularPictureBox Avatar;
        private Label Role;
        private Panel panel2;
        private FlowLayoutPanel MessagesPanel;
        private PictureBox Send;
        private TextBox Content;
    }
}
