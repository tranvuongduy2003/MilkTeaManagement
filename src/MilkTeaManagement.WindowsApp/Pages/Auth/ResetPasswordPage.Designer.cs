namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    partial class ResetPasswordPage
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
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            openRegisterFormButton = new Label();
            label4 = new Label();
            loginButton = new Button();
            label3 = new Label();
            emailTextBox = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(openRegisterFormButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(126, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 437);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10F);
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(3, 391);
            label5.Name = "label5";
            label5.Size = new Size(444, 35);
            label5.TabIndex = 12;
            label5.Text = "Login";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 10F);
            label6.Location = new Point(3, 356);
            label6.Name = "label6";
            label6.Size = new Size(444, 35);
            label6.TabIndex = 11;
            label6.Text = "You already have an account?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openRegisterFormButton
            // 
            openRegisterFormButton.Font = new Font("Tahoma", 10F);
            openRegisterFormButton.ForeColor = Color.FromArgb(128, 128, 255);
            openRegisterFormButton.Location = new Point(0, 321);
            openRegisterFormButton.Name = "openRegisterFormButton";
            openRegisterFormButton.Size = new Size(444, 35);
            openRegisterFormButton.TabIndex = 7;
            openRegisterFormButton.Text = "Register";
            openRegisterFormButton.TextAlign = ContentAlignment.MiddleCenter;
            openRegisterFormButton.Click += openRegisterPageButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 10F);
            label4.Location = new Point(0, 286);
            label4.Name = "label4";
            label4.Size = new Size(444, 35);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(128, 128, 255);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FromArgb(255, 251, 228);
            loginButton.Location = new Point(3, 209);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(444, 41);
            loginButton.TabIndex = 5;
            loginButton.Text = "Reset Password";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += resetPasswordButton_ClickAsync;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(3, 91);
            label3.Name = "label3";
            label3.Size = new Size(444, 43);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.None;
            emailTextBox.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(3, 137);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(444, 34);
            emailTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 43);
            label1.TabIndex = 0;
            label1.Text = "Reset Password";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.multiply;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1223, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ResetPasswordPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.Login_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 678);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResetPasswordPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox emailTextBox;
        private Label label1;
        private Button loginButton;
        private Label openRegisterFormButton;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
    }
}