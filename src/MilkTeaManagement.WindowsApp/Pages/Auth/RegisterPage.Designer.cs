using MilkTeaManagement.WindowsApp.UserControls.Common;
using System.Windows.Forms;

namespace MilkTeaManagement.WindowsApp.Pages.Auth
{
    partial class RegisterPage
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
            avatarUpload = new CircularPictureBox();
            label8 = new Label();
            label7 = new Label();
            emailTextBox = new TextBox();
            label6 = new Label();
            passwordTextBox = new TextBox();
            label5 = new Label();
            userNameTextBox = new TextBox();
            openLoginFormButton = new Label();
            label4 = new Label();
            registerButton = new Button();
            label3 = new Label();
            confirmPasswordTextBox = new TextBox();
            label2 = new Label();
            fullNameTextBox = new TextBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatarUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(avatarUpload);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(userNameTextBox);
            panel1.Controls.Add(openLoginFormButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(registerButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(confirmPasswordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fullNameTextBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(680, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 955);
            panel1.TabIndex = 0;
            // 
            // avatarUpload
            // 
            avatarUpload.BackgroundImage = Properties.Resources.upload_image__1_;
            avatarUpload.BackgroundImageLayout = ImageLayout.Stretch;
            avatarUpload.ErrorImage = null;
            avatarUpload.InitialImage = null;
            avatarUpload.Location = new Point(165, 102);
            avatarUpload.Name = "avatarUpload";
            avatarUpload.Size = new Size(120, 120);
            avatarUpload.SizeMode = PictureBoxSizeMode.CenterImage;
            avatarUpload.TabIndex = 18;
            avatarUpload.TabStop = false;
            avatarUpload.Click += avatarUpload_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Poppins", 12F);
            label8.Location = new Point(3, 57);
            label8.Name = "label8";
            label8.Size = new Size(444, 43);
            label8.TabIndex = 17;
            label8.Text = "Avatar:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Font = new Font("Poppins", 12F);
            label7.Location = new Point(3, 440);
            label7.Name = "label7";
            label7.Size = new Size(444, 43);
            label7.TabIndex = 16;
            label7.Text = "Email:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(3, 486);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(444, 49);
            emailTextBox.TabIndex = 15;
            // 
            // label6
            // 
            label6.Font = new Font("Poppins", 12F);
            label6.Location = new Point(3, 550);
            label6.Name = "label6";
            label6.Size = new Size(444, 43);
            label6.TabIndex = 14;
            label6.Text = "Password:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(3, 596);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '•';
            passwordTextBox.Size = new Size(444, 49);
            passwordTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.Font = new Font("Poppins", 12F);
            label5.Location = new Point(3, 330);
            label5.Name = "label5";
            label5.Size = new Size(444, 43);
            label5.TabIndex = 12;
            label5.Text = "Username:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            userNameTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(3, 376);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(444, 49);
            userNameTextBox.TabIndex = 11;
            // 
            // openLoginFormButton
            // 
            openLoginFormButton.Font = new Font("Poppins", 10F);
            openLoginFormButton.ForeColor = Color.FromArgb(128, 128, 255);
            openLoginFormButton.Location = new Point(3, 913);
            openLoginFormButton.Name = "openLoginFormButton";
            openLoginFormButton.Size = new Size(444, 35);
            openLoginFormButton.TabIndex = 7;
            openLoginFormButton.Text = "Login";
            openLoginFormButton.TextAlign = ContentAlignment.MiddleCenter;
            openLoginFormButton.Click += openLoginPageButton_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Poppins", 10F);
            label4.Location = new Point(3, 878);
            label4.Name = "label4";
            label4.Size = new Size(444, 35);
            label4.TabIndex = 6;
            label4.Text = "You already have an account?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(128, 128, 255);
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerButton.ForeColor = Color.FromArgb(192, 192, 255);
            registerButton.Location = new Point(3, 801);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(444, 48);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_ClickAsync;
            // 
            // label3
            // 
            label3.Font = new Font("Poppins", 12F);
            label3.Location = new Point(3, 660);
            label3.Name = "label3";
            label3.Size = new Size(444, 43);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTextBox.Location = new Point(3, 706);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '•';
            confirmPasswordTextBox.Size = new Size(444, 49);
            confirmPasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins", 12F);
            label2.Location = new Point(3, 220);
            label2.Name = "label2";
            label2.Size = new Size(444, 43);
            label2.TabIndex = 2;
            label2.Text = "Fullname:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            fullNameTextBox.Font = new Font("Poppins", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameTextBox.Location = new Point(3, 266);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(444, 49);
            fullNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 43);
            label1.TabIndex = 0;
            label1.Text = "Please Fill out form to Register!";
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
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.register_background;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 1047);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avatarUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox confirmPasswordTextBox;
        private Label label2;
        private TextBox fullNameTextBox;
        private Label label1;
        private Button registerButton;
        private Label openLoginFormButton;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
        private TextBox userNameTextBox;
        private Label label6;
        private TextBox passwordTextBox;
        private Label label7;
        private TextBox textBox1;
        private TextBox emailTextBox;
        private CircularPictureBox avatarUpload;
        private Label label8;
    }
}