namespace MilkTeaManagement.WindowsApp.Forms.Employees
{
    partial class DetailEmployeeForm
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
            informationPanel = new Panel();
            Update = new Button();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            StatusComboBox = new ComboBox();
            RoleComboBox = new ComboBox();
            PhoneNumberTextbox = new TextBox();
            DOBDateTimePicker = new DateTimePicker();
            UserNameTextbox = new TextBox();
            GenderComboBox = new ComboBox();
            EmailTextbox = new TextBox();
            FullNameTextbox = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            status = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            fullName = new Label();
            role = new Label();
            Avatar = new UserControls.Common.CircularPictureBox();
            panel2 = new Panel();
            WorkDayButton = new Button();
            CheckoutHistoryButton = new Button();
            ContentPanel = new Panel();
            panel1 = new Panel();
            closeButton = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new PictureBox();
            pictureBox9 = new PictureBox();
            SalaryTextBox = new TextBox();
            label1 = new Label();
            informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // informationPanel
            // 
            informationPanel.BackColor = Color.White;
            informationPanel.Controls.Add(label1);
            informationPanel.Controls.Add(SalaryTextBox);
            informationPanel.Controls.Add(pictureBox9);
            informationPanel.Controls.Add(Update);
            informationPanel.Controls.Add(pictureBox8);
            informationPanel.Controls.Add(pictureBox7);
            informationPanel.Controls.Add(pictureBox6);
            informationPanel.Controls.Add(StatusComboBox);
            informationPanel.Controls.Add(RoleComboBox);
            informationPanel.Controls.Add(PhoneNumberTextbox);
            informationPanel.Controls.Add(DOBDateTimePicker);
            informationPanel.Controls.Add(UserNameTextbox);
            informationPanel.Controls.Add(GenderComboBox);
            informationPanel.Controls.Add(EmailTextbox);
            informationPanel.Controls.Add(FullNameTextbox);
            informationPanel.Controls.Add(pictureBox2);
            informationPanel.Controls.Add(pictureBox1);
            informationPanel.Controls.Add(status);
            informationPanel.Controls.Add(pictureBox5);
            informationPanel.Controls.Add(pictureBox4);
            informationPanel.Controls.Add(pictureBox3);
            informationPanel.Controls.Add(panel5);
            informationPanel.Location = new Point(0, 30);
            informationPanel.Margin = new Padding(0);
            informationPanel.Name = "informationPanel";
            informationPanel.Size = new Size(600, 1050);
            informationPanel.TabIndex = 0;
            // 
            // Update
            // 
            Update.AutoSize = true;
            Update.BackColor = Color.SteelBlue;
            Update.Font = new Font("Poppins", 12F);
            Update.ForeColor = Color.White;
            Update.Location = new Point(150, 625);
            Update.Margin = new Padding(0);
            Update.Name = "Update";
            Update.Size = new Size(300, 52);
            Update.TabIndex = 68;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = Properties.Resources.user_role;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(40, 510);
            pictureBox8.Margin = new Padding(0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(30, 30);
            pictureBox8.TabIndex = 67;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.id_card;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(40, 160);
            pictureBox7.Margin = new Padding(0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(30, 30);
            pictureBox7.TabIndex = 66;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.id_card;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(40, 210);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Font = new Font("Poppins", 10F);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            StatusComboBox.Location = new Point(80, 455);
            StatusComboBox.Margin = new Padding(0);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(234, 44);
            StatusComboBox.TabIndex = 64;
            // 
            // RoleComboBox
            // 
            RoleComboBox.Font = new Font("Poppins", 11F);
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Cashier", "Barista" });
            RoleComboBox.Location = new Point(80, 505);
            RoleComboBox.Margin = new Padding(0);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(234, 47);
            RoleComboBox.TabIndex = 63;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTextbox.Font = new Font("Poppins", 11F);
            PhoneNumberTextbox.Location = new Point(80, 305);
            PhoneNumberTextbox.Margin = new Padding(0);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.PlaceholderText = "   Phone Number";
            PhoneNumberTextbox.Size = new Size(477, 40);
            PhoneNumberTextbox.TabIndex = 62;
            // 
            // DOBDateTimePicker
            // 
            DOBDateTimePicker.Font = new Font("Poppins", 11F);
            DOBDateTimePicker.Location = new Point(80, 405);
            DOBDateTimePicker.Margin = new Padding(0);
            DOBDateTimePicker.Name = "DOBDateTimePicker";
            DOBDateTimePicker.Size = new Size(468, 40);
            DOBDateTimePicker.TabIndex = 58;
            // 
            // UserNameTextbox
            // 
            UserNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextbox.Font = new Font("Poppins", 11F);
            UserNameTextbox.Location = new Point(80, 155);
            UserNameTextbox.Margin = new Padding(0);
            UserNameTextbox.Name = "UserNameTextbox";
            UserNameTextbox.PlaceholderText = "   User Name";
            UserNameTextbox.Size = new Size(476, 40);
            UserNameTextbox.TabIndex = 52;
            // 
            // GenderComboBox
            // 
            GenderComboBox.Font = new Font("Poppins", 10F);
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            GenderComboBox.Location = new Point(80, 355);
            GenderComboBox.Margin = new Padding(0);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(234, 44);
            GenderComboBox.TabIndex = 56;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextbox.Font = new Font("Poppins", 11F);
            EmailTextbox.Location = new Point(80, 255);
            EmailTextbox.Margin = new Padding(0);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.PlaceholderText = "   Email";
            EmailTextbox.Size = new Size(477, 40);
            EmailTextbox.TabIndex = 54;
            // 
            // FullNameTextbox
            // 
            FullNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextbox.Font = new Font("Poppins", 11F);
            FullNameTextbox.Location = new Point(80, 205);
            FullNameTextbox.Margin = new Padding(0);
            FullNameTextbox.Name = "FullNameTextbox";
            FullNameTextbox.PlaceholderText = "   Full Name";
            FullNameTextbox.Size = new Size(476, 40);
            FullNameTextbox.TabIndex = 50;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.phone;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(39, 310);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Frame1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(39, 260);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Poppins", 11F);
            status.Location = new Point(79, 455);
            status.Margin = new Padding(0);
            status.Name = "status";
            status.Size = new Size(92, 39);
            status.TabIndex = 23;
            status.Text = "ACTIVE";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.status;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(39, 460);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.birthday_cake;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(39, 410);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.gender_fluid;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(39, 360);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(fullName);
            panel5.Controls.Add(role);
            panel5.Controls.Add(Avatar);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 140);
            panel5.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(20, 138);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 2);
            panel3.TabIndex = 1;
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Font = new Font("Poppins", 13F);
            fullName.Location = new Point(150, 70);
            fullName.Margin = new Padding(0);
            fullName.Name = "fullName";
            fullName.Size = new Size(150, 46);
            fullName.TabIndex = 2;
            fullName.Text = "Customer";
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Poppins", 9F);
            role.ForeColor = SystemColors.ControlDark;
            role.Location = new Point(150, 35);
            role.Margin = new Padding(0);
            role.Name = "role";
            role.Size = new Size(105, 31);
            role.TabIndex = 1;
            role.Text = "Customer";
            // 
            // Avatar
            // 
            Avatar.BackgroundImage = Properties.Resources.avatar;
            Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar.Location = new Point(40, 20);
            Avatar.Margin = new Padding(0);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(100, 100);
            Avatar.TabIndex = 0;
            Avatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(WorkDayButton);
            panel2.Controls.Add(CheckoutHistoryButton);
            panel2.Controls.Add(ContentPanel);
            panel2.Location = new Point(600, 30);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1220, 1050);
            panel2.TabIndex = 1;
            // 
            // WorkDayButton
            // 
            WorkDayButton.AutoSize = true;
            WorkDayButton.BackColor = Color.FromArgb(128, 128, 255);
            WorkDayButton.FlatAppearance.BorderSize = 0;
            WorkDayButton.FlatStyle = FlatStyle.Flat;
            WorkDayButton.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WorkDayButton.ForeColor = Color.White;
            WorkDayButton.Location = new Point(310, 35);
            WorkDayButton.Margin = new Padding(0);
            WorkDayButton.Name = "WorkDayButton";
            WorkDayButton.Size = new Size(270, 52);
            WorkDayButton.TabIndex = 18;
            WorkDayButton.Text = "Work days";
            WorkDayButton.UseVisualStyleBackColor = false;
            WorkDayButton.Click += WorkDayButton_Click;
            // 
            // CheckoutHistoryButton
            // 
            CheckoutHistoryButton.AutoSize = true;
            CheckoutHistoryButton.BackColor = Color.FromArgb(128, 128, 255);
            CheckoutHistoryButton.FlatAppearance.BorderSize = 0;
            CheckoutHistoryButton.FlatStyle = FlatStyle.Flat;
            CheckoutHistoryButton.Font = new Font("Poppins Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckoutHistoryButton.ForeColor = Color.White;
            CheckoutHistoryButton.Location = new Point(20, 35);
            CheckoutHistoryButton.Margin = new Padding(0);
            CheckoutHistoryButton.Name = "CheckoutHistoryButton";
            CheckoutHistoryButton.Size = new Size(270, 52);
            CheckoutHistoryButton.TabIndex = 17;
            CheckoutHistoryButton.Text = "Checkout History";
            CheckoutHistoryButton.UseVisualStyleBackColor = false;
            CheckoutHistoryButton.Click += CheckoutHistoryButton_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Location = new Point(20, 120);
            ContentPanel.Margin = new Padding(0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1180, 905);
            ContentPanel.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1820, 30);
            panel1.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImage = Properties.Resources.multiply;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Location = new Point(1790, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 13;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(79, 673);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Transparent;
            close.BackgroundImage = Properties.Resources.multiply;
            close.BackgroundImageLayout = ImageLayout.Stretch;
            close.Location = new Point(1890, 0);
            close.Margin = new Padding(0);
            close.Name = "close";
            close.Size = new Size(30, 30);
            close.TabIndex = 12;
            close.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = Properties.Resources.salary;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(40, 565);
            pictureBox9.Margin = new Padding(0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(30, 30);
            pictureBox9.TabIndex = 69;
            pictureBox9.TabStop = false;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SalaryTextBox.BorderStyle = BorderStyle.FixedSingle;
            SalaryTextBox.Font = new Font("Poppins", 11F);
            SalaryTextBox.Location = new Point(80, 560);
            SalaryTextBox.Margin = new Padding(0);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.PlaceholderText = "   Hourly Salary";
            SalaryTextBox.Size = new Size(234, 40);
            SalaryTextBox.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11F);
            label1.Location = new Point(320, 560);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(99, 39);
            label1.TabIndex = 3;
            label1.Text = "VNĐ / h";
            // 
            // DetailEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1820, 1080);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(informationPanel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(0);
            Name = "DetailEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            informationPanel.ResumeLayout(false);
            informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel informationPanel;
        private Panel panel2;
        private Panel panel1;
        private PictureBox closeButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private Panel panel5;
        private Panel panel3;
        private Label fullName;
        private Label role;
        private UserControls.Common.CircularPictureBox Avatar;
        private ComboBox StatusComboBox;
        private ComboBox RoleComboBox;
        private TextBox PhoneNumberTextbox;
        private DateTimePicker DOBDateTimePicker;
        private ComboBox GenderComboBox;
        private TextBox EmailTextbox;
        private TextBox UserNameTextbox;
        private TextBox FullNameTextbox;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label status;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Button Update;
        private Panel ContentPanel;
        private Button CheckoutHistoryButton;
        private Button WorkDayButton;
        private PictureBox pictureBox9;
        private TextBox SalaryTextBox;
        private Label label1;
    }
}