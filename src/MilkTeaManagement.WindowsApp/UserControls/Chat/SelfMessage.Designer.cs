namespace MilkTeaManagement.WindowsApp.UserControls.Chat
{
    partial class SelfMessage
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
            Message = new RichTextBox();
            SuspendLayout();
            // 
            // Message
            // 
            Message.BackColor = Color.White;
            Message.BorderStyle = BorderStyle.None;
            Message.Font = new Font("Poppins", 12F);
            Message.ForeColor = Color.Black;
            Message.Location = new Point(300, 0);
            Message.Margin = new Padding(0);
            Message.MinimumSize = new Size(940, 45);
            Message.Name = "Message";
            Message.RightToLeft = RightToLeft.Yes;
            Message.ScrollBars = RichTextBoxScrollBars.None;
            Message.Size = new Size(940, 45);
            Message.TabIndex = 0;
            Message.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // SelfMessage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(Message);
            Margin = new Padding(0);
            MinimumSize = new Size(1260, 45);
            Name = "SelfMessage";
            Size = new Size(1260, 45);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox Message;
    }
}
