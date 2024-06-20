using MilkTeaManagement.WindowsApp.UserControls.Common;

namespace MilkTeaManagement.WindowsApp.UserControls.Chat 
{
    partial class UserBoxControl
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
            avatar = new CircularPictureBox();
            fullName = new Label();
            message = new Label();
            label3 = new Label();
            time = new Label();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            SuspendLayout();
            // 
            // avatar
            // 
            avatar.BackColor = Color.White;
            avatar.BackgroundImage = Properties.Resources.avatar;
            avatar.BackgroundImageLayout = ImageLayout.Stretch;
            avatar.Location = new Point(20, 20);
            avatar.Name = "avatar";
            avatar.Size = new Size(80, 80);
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // fullName
            // 
            fullName.AutoEllipsis = true;
            fullName.Font = new Font("Poppins", 10F, FontStyle.Bold);
            fullName.ImageAlign = ContentAlignment.MiddleLeft;
            fullName.Location = new Point(120, 25);
            fullName.Margin = new Padding(0);
            fullName.MaximumSize = new Size(339, 30);
            fullName.Name = "fullName";
            fullName.Size = new Size(339, 30);
            fullName.TabIndex = 1;
            fullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // message
            // 
            message.AutoEllipsis = true;
            message.Font = new Font("Poppins", 10F);
            message.ImageAlign = ContentAlignment.MiddleLeft;
            message.Location = new Point(120, 68);
            message.Margin = new Padding(0);
            message.MaximumSize = new Size(339, 30);
            message.Name = "message";
            message.Size = new Size(339, 30);
            message.TabIndex = 2;
            message.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(462, 37);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(38, 48);
            label3.TabIndex = 3;
            label3.Text = "•";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Tahoma", 8F);
            time.ImageAlign = ContentAlignment.MiddleRight;
            time.Location = new Point(319, 6);
            time.Margin = new Padding(0);
            time.MaximumSize = new Size(206, 30);
            time.Name = "time";
            time.Size = new Size(0, 19);
            time.TabIndex = 4;
            time.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UserBoxControl
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(time);
            Controls.Add(label3);
            Controls.Add(message);
            Controls.Add(fullName);
            Controls.Add(avatar);
            Margin = new Padding(0, 0, 0, 5);
            Name = "UserBoxControl";
            Size = new Size(500, 120);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularPictureBox avatar;
        private Label fullName;
        private Label message;
        private Label label3;
        private Label time;
    }
}
