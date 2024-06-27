namespace MilkTeaManagement.WindowsApp.Pages.Chat
{
    partial class ChatPage
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
            ConversationsPanel = new FlowLayoutPanel();
            ChatView = new Panel();
            SuspendLayout();
            // 
            // ConversationsPanel
            // 
            ConversationsPanel.AutoScroll = true;
            ConversationsPanel.BackColor = Color.Silver;
            ConversationsPanel.Location = new Point(0, 0);
            ConversationsPanel.Margin = new Padding(0);
            ConversationsPanel.Name = "ConversationsPanel";
            ConversationsPanel.Size = new Size(530, 1050);
            ConversationsPanel.TabIndex = 0;
            // 
            // ChatView
            // 
            ChatView.Location = new Point(530, 0);
            ChatView.Margin = new Padding(0);
            ChatView.Name = "ChatView";
            ChatView.Size = new Size(1290, 1050);
            ChatView.TabIndex = 1;
            // 
            // ChatPage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(ChatView);
            Controls.Add(ConversationsPanel);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "ChatPage";
            Size = new Size(1820, 1050);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ConversationsPanel;
        private Panel ChatView;
    }
}
