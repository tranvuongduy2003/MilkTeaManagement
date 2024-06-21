namespace MilkTeaManagement.WindowsApp.Forms.Employees
{
    partial class CreateEmployeeForm
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
            closeButton = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            close = new PictureBox();
            label1 = new Label();
            Avatar = new PictureBox();
            label6 = new Label();
            Create = new Button();
            PhoneNumberTextbox = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            DOBDateTimePicker = new DateTimePicker();
            label7 = new Label();
            GenderComboBox = new ComboBox();
            label3 = new Label();
            EmailTextbox = new TextBox();
            label5 = new Label();
            UserNameTextbox = new TextBox();
            label4 = new Label();
            FullNameTextbox = new TextBox();
            label10 = new Label();
            RoleComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Avatar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(close);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 30);
            panel1.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImage = Properties.Resources.multiply;
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Location = new Point(994, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 11F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 143);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(95, 39);
            label1.TabIndex = 2;
            label1.Text = "Avatar:";
            // 
            // Avatar
            // 
            Avatar.BackColor = Color.White;
            Avatar.BackgroundImage = Properties.Resources.upload_image1;
            Avatar.BackgroundImageLayout = ImageLayout.Zoom;
            Avatar.Location = new Point(36, 185);
            Avatar.Name = "Avatar";
            Avatar.Size = new Size(250, 250);
            Avatar.TabIndex = 3;
            Avatar.TabStop = false;
            Avatar.Click += Avatar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Medium", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 55);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(494, 70);
            label6.TabIndex = 19;
            label6.Text = "Create New Employee";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Create
            // 
            Create.AutoSize = true;
            Create.BackColor = Color.SteelBlue;
            Create.Font = new Font("Poppins", 12F);
            Create.ForeColor = Color.White;
            Create.Location = new Point(320, 971);
            Create.Margin = new Padding(0);
            Create.Name = "Create";
            Create.Size = new Size(384, 52);
            Create.TabIndex = 20;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            Create.Click += create_Click;
            // 
            // PhoneNumberTextbox
            // 
            PhoneNumberTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PhoneNumberTextbox.BorderStyle = BorderStyle.FixedSingle;
            PhoneNumberTextbox.Font = new Font("Poppins", 11F);
            PhoneNumberTextbox.Location = new Point(322, 482);
            PhoneNumberTextbox.Margin = new Padding(0);
            PhoneNumberTextbox.Name = "PhoneNumberTextbox";
            PhoneNumberTextbox.PlaceholderText = "   Phone Number";
            PhoneNumberTextbox.Size = new Size(660, 40);
            PhoneNumberTextbox.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 11F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(322, 443);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(186, 39);
            label2.TabIndex = 45;
            label2.Text = "Phone Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 11F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(322, 843);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(91, 39);
            label9.TabIndex = 43;
            label9.Text = "Status:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 11F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(322, 743);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(68, 39);
            label8.TabIndex = 41;
            label8.Text = "Role:";
            // 
            // DOBDateTimePicker
            // 
            DOBDateTimePicker.Font = new Font("Poppins", 11F);
            DOBDateTimePicker.Location = new Point(322, 682);
            DOBDateTimePicker.Margin = new Padding(0);
            DOBDateTimePicker.Name = "DOBDateTimePicker";
            DOBDateTimePicker.Size = new Size(468, 40);
            DOBDateTimePicker.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 11F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(322, 643);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(158, 39);
            label7.TabIndex = 39;
            label7.Text = "Date of birth:";
            // 
            // GenderComboBox
            // 
            GenderComboBox.Font = new Font("Poppins", 11F);
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Items.AddRange(new object[] { "MALE", "FEMALE" });
            GenderComboBox.Location = new Point(322, 582);
            GenderComboBox.Margin = new Padding(0);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(234, 47);
            GenderComboBox.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 11F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 543);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(104, 39);
            label3.TabIndex = 37;
            label3.Text = "Gender:";
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EmailTextbox.BorderStyle = BorderStyle.FixedSingle;
            EmailTextbox.Font = new Font("Poppins", 11F);
            EmailTextbox.Location = new Point(322, 382);
            EmailTextbox.Margin = new Padding(0);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.PlaceholderText = "   Email";
            EmailTextbox.Size = new Size(660, 40);
            EmailTextbox.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 11F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(322, 343);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(81, 39);
            label5.TabIndex = 35;
            label5.Text = "Email:";
            // 
            // UserNameTextbox
            // 
            UserNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            UserNameTextbox.Font = new Font("Poppins", 11F);
            UserNameTextbox.Location = new Point(322, 282);
            UserNameTextbox.Margin = new Padding(0);
            UserNameTextbox.Name = "UserNameTextbox";
            UserNameTextbox.PlaceholderText = "   User Name";
            UserNameTextbox.ReadOnly = true;
            UserNameTextbox.Size = new Size(660, 40);
            UserNameTextbox.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 11F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(322, 243);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(143, 39);
            label4.TabIndex = 33;
            label4.Text = "User Name:";
            // 
            // FullNameTextbox
            // 
            FullNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FullNameTextbox.BorderStyle = BorderStyle.FixedSingle;
            FullNameTextbox.Font = new Font("Poppins", 11F);
            FullNameTextbox.Location = new Point(322, 182);
            FullNameTextbox.Margin = new Padding(0);
            FullNameTextbox.Name = "FullNameTextbox";
            FullNameTextbox.PlaceholderText = "   Full Name";
            FullNameTextbox.Size = new Size(660, 40);
            FullNameTextbox.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 11F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(322, 143);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(130, 39);
            label10.TabIndex = 31;
            label10.Text = "Full Name:";
            // 
            // RoleComboBox
            // 
            RoleComboBox.Font = new Font("Poppins", 11F);
            RoleComboBox.FormattingEnabled = true;
            RoleComboBox.Items.AddRange(new object[] { "Admin", "Manager", "Cashier", "Barista" });
            RoleComboBox.Location = new Point(322, 782);
            RoleComboBox.Margin = new Padding(0);
            RoleComboBox.Name = "RoleComboBox";
            RoleComboBox.Size = new Size(234, 47);
            RoleComboBox.TabIndex = 47;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Font = new Font("Poppins", 11F);
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "ACTIVE", "INACTIVE" });
            StatusComboBox.Location = new Point(322, 882);
            StatusComboBox.Margin = new Padding(0);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(234, 47);
            StatusComboBox.TabIndex = 48;
            // 
            // CreateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1024, 1051);
            Controls.Add(StatusComboBox);
            Controls.Add(RoleComboBox);
            Controls.Add(PhoneNumberTextbox);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(DOBDateTimePicker);
            Controls.Add(label7);
            Controls.Add(GenderComboBox);
            Controls.Add(label3);
            Controls.Add(EmailTextbox);
            Controls.Add(label5);
            Controls.Add(UserNameTextbox);
            Controls.Add(label4);
            Controls.Add(FullNameTextbox);
            Controls.Add(label10);
            Controls.Add(Create);
            Controls.Add(label6);
            Controls.Add(Avatar);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateProductForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)close).EndInit();
            ((System.ComponentModel.ISupportInitialize)Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox close;
        private PictureBox closeButton;
        private Label label1;
        private PictureBox Avatar;
        private Label label6;
        private Button Create;
        private TextBox PhoneNumberTextbox;
        private Label label2;
        private Label label9;
        private Label label8;
        private DateTimePicker DOBDateTimePicker;
        private Label label7;
        private ComboBox GenderComboBox;
        private Label label3;
        private TextBox EmailTextbox;
        private Label label5;
        private TextBox UserNameTextbox;
        private Label label4;
        private TextBox FullNameTextbox;
        private Label label10;
        private ComboBox RoleComboBox;
        private ComboBox StatusComboBox;
    }
}