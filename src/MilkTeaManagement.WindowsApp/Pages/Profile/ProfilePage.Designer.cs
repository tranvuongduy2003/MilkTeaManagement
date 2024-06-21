namespace MilkTeaManagement.WindowsApp.Pages.Profile
{
    partial class ProfilePage
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
            label1 = new Label();
            Avatar = new PictureBox();
            AvatarLabel = new Label();
            FullNameTextbox = new TextBox();
            label3 = new Label();
            UserNameTextbox = new TextBox();
            label4 = new Label();
            EmailTextbox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            GenderComboBox = new ComboBox();
            label7 = new Label();
            DOBDateTimePicker = new DateTimePicker();
            RoleTextbox = new TextBox();
            label8 = new Label();
            StatusTextbox = new TextBox();
            label9 = new Label();
            Update = new Button();
            PhoneNumberTextbox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 30);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(162, 70);
            label1.TabIndex = 3;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.White;
            Avatar.BackgroundImage = Properties.Resources.upload_image1;
            Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar.Location = new Point(101, 184);
            Avatar.Margin = new Padding(0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(550, 550);
            Avatar.TabIndex = 4;
            Avatar.TabStop = false;
            Avatar.Click += Avatar_Click;
            // 
            // AvatarLabel
            // 
            AvatarLabel.AutoSize = true;
            AvatarLabel.Font = new Font("Poppins", 11F);
            AvatarLabel.ForeColor = Color.White;
            AvatarLabel.Location = new Point(101, 142);
            AvatarLabel.Margin = new Padding(0);
            AvatarLabel.Name = "AvatarLabel";
            AvatarLabel.Size = new Size(95, 39);
            AvatarLabel.TabIndex = 5;
            AvatarLabel.Text = "Avatar:";
            // 
            // FullNameTextbox
            // 
            FullNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextbox.Font = new Font("Poppins", 11F);
            FullNameTextbox.Location = new Point(719, 181);
            FullNameTextbox.Margin = new Padding(0);
            FullNameTextbox.Name = "FullNameTextbox";
            FullNameTextbox.PlaceholderText = "   Full Name";
            FullNameTextbox.Size = new Size(1012, 40);
            FullNameTextbox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(719, 142);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(130, 39);
            label3.TabIndex = 13;
            label3.Text = "Full Name:";
            // 
            // UserNameTextbox
            // 
            UserNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextbox.Font = new Font("Poppins", 11F);
            UserNameTextbox.Location = new Point(719, 281);
            UserNameTextbox.Margin = new Padding(0);
            UserNameTextbox.Name = "UserNameTextbox";
            UserNameTextbox.PlaceholderText = "   User Name";
            UserNameTextbox.ReadOnly = true;
            UserNameTextbox.Size = new Size(1012, 40);
            UserNameTextbox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(719, 242);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(143, 39);
            label4.TabIndex = 15;
            label4.Text = "User Name:";
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextbox.Font = new Font("Poppins", 11F);
            EmailTextbox.Location = new Point(719, 381);
            EmailTextbox.Margin = new Padding(0);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.PlaceholderText = "   Email";
            EmailTextbox.Size = new Size(1012, 40);
            EmailTextbox.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(719, 342);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(81, 39);
            label5.TabIndex = 17;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 11F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(719, 542);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(104, 39);
            label6.TabIndex = 19;
            label6.Text = "Gender:";
            // 
            // GenderComboBox
            // 
            GenderComboBox.Font = new Font("Poppins", 11F);
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            GenderComboBox.Location = new Point(719, 581);
            GenderComboBox.Margin = new Padding(0);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(182, 47);
            GenderComboBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(719, 642);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(158, 39);
            label7.TabIndex = 21;
            label7.Text = "Date of birth:";
            // 
            // DOBDateTimePicker
            // 
            DOBDateTimePicker.Font = new Font("Poppins", 11F);
            DOBDateTimePicker.Location = new Point(719, 681);
            DOBDateTimePicker.Margin = new Padding(0);
            DOBDateTimePicker.Name = "DOBDateTimePicker";
            DOBDateTimePicker.Size = new Size(500, 40);
            DOBDateTimePicker.TabIndex = 23;
            // 
            // RoleTextbox
            // 
            RoleTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RoleTextbox.BorderStyle = BorderStyle.FixedSingle;
            RoleTextbox.Font = new Font("Poppins", 11F);
            RoleTextbox.Location = new Point(719, 781);
            RoleTextbox.Margin = new Padding(0);
            RoleTextbox.Name = "RoleTextbox";
            RoleTextbox.PlaceholderText = "   Role";
            RoleTextbox.ReadOnly = true;
            RoleTextbox.Size = new Size(1012, 40);
            RoleTextbox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(719, 742);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(68, 39);
            label8.TabIndex = 24;
            label8.Text = "Role:";
            // 
            // StatusTextbox
            // 
            StatusTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StatusTextbox.BorderStyle = BorderStyle.FixedSingle;
            StatusTextbox.Font = new Font("Poppins", 11F);
            StatusTextbox.Location = new Point(719, 881);
            StatusTextbox.Margin = new Padding(0);
            StatusTextbox.Name = "StatusTextbox";
            StatusTextbox.PlaceholderText = "   Status";
            StatusTextbox.ReadOnly = true;
            StatusTextbox.Size = new Size(1012, 40);
            StatusTextbox.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 11F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(719, 842);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(91, 39);
            label9.TabIndex = 26;
            label9.Text = "Status:";
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.BackColor = Color.FromArgb(192, 192, 0);
            Update.Font = new Font("Poppins", 12F);
            Update.ForeColor = Color.White;
            Update.Location = new Point(720, 958);
            Update.Margin = new Padding(0);
            Update.Name = "Update";
            Update.Size = new Size(380, 52);
            Update.TabIndex = 28;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTextbox.Font = new Font("Poppins", 11F);
            PhoneNumberTextbox.Location = new Point(719, 481);
            PhoneNumberTextbox.Margin = new Padding(0);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.PlaceholderText = "   Phone Number";
            PhoneNumberTextbox.Size = new Size(1012, 40);
            PhoneNumberTextbox.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(719, 442);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(186, 39);
            label2.TabIndex = 29;
            label2.Text = "Phone Number:";
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(label2);
            Controls.Add(Update);
            Controls.Add(StatusTextbox);
            Controls.Add(label9);
            Controls.Add(RoleTextbox);
            Controls.Add(label8);
            Controls.Add(DOBDateTimePicker);
            Controls.Add(label7);
            Controls.Add(GenderComboBox);
            Controls.Add(label6);
            Controls.Add(EmailTextbox);
            Controls.Add(label5);
            Controls.Add(UserNameTextbox);
            Controls.Add(label4);
            Controls.Add(FullNameTextbox);
            Controls.Add(label3);
            Controls.Add(AvatarLabel);
            Controls.Add(Avatar);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ProfilePage";
            Size = new Size(1820, 1050);
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Avatar;
        private Label AvatarLabel;
        private TextBox FullNameTextbox;
        private Label label3;
        private TextBox UserNameTextbox;
        private Label label4;
        private TextBox EmailTextbox;
        private Label label5;
        private Label label6;
        private ComboBox GenderComboBox;
        private Label label7;
        private DateTimePicker DOBDateTimePicker;
        private TextBox RoleTextbox;
        private Label label8;
        private TextBox StatusTextbox;
        private Label label9;
        private Button Update;
        private TextBox PhoneNumberTextbox;
        private Label label2;
    }
}
