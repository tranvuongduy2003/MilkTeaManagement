namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    partial class LoginPage
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            userNameTextBox = new TextBox();
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
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(129, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 533);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Font = new Font("Poppins", 10F);
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(0, 498);
            label5.Name = "label5";
            label5.Size = new Size(444, 35);
            label5.TabIndex = 12;
            label5.Text = "Reset Password";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Poppins", 10F);
            label6.Location = new Point(0, 463);
            label6.Name = "label6";
            label6.Size = new Size(444, 35);
            label6.TabIndex = 11;
            label6.Text = "Or if you forget you password?";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openRegisterFormButton
            // 
            openRegisterFormButton.Font = new Font("Poppins", 10F);
            openRegisterFormButton.ForeColor = Color.FromArgb(128, 128, 255);
            openRegisterFormButton.Location = new Point(3, 428);
            openRegisterFormButton.Name = "openRegisterFormButton";
            openRegisterFormButton.Size = new Size(444, 35);
            openRegisterFormButton.TabIndex = 7;
            openRegisterFormButton.Text = "Register";
            openRegisterFormButton.TextAlign = ContentAlignment.MiddleCenter;
            openRegisterFormButton.Click += openRegisterPageButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Poppins", 10F);
            label4.Location = new Point(3, 393);
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
            loginButton.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FromArgb(192, 192, 255);
            loginButton.Location = new Point(3, 316);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(444, 49);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Poppins", 12F);
            label3.Location = new Point(3, 188);
            label3.Name = "label3";
            label3.Size = new Size(444, 43);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(3, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(444, 49);
            passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins", 12F);
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(444, 43);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userNameTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(3, 128);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(444, 49);
            userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome Back!";
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
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.Login_Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1280, 798);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginPage";
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
        private TextBox passwordTextBox;
        private Label label2;
        private TextBox userNameTextBox;
        private Label label1;
        private Button loginButton;
        private Label openRegisterFormButton;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
    }
}