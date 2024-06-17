namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    partial class InformationPanel
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
            pictureBox1 = new PictureBox();
            email = new Label();
            phoneNumber = new Label();
            pictureBox2 = new PictureBox();
            circularPictureBox1 = new Common.CircularPictureBox();
            role = new Label();
            fullName = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            gender = new Label();
            pictureBox3 = new PictureBox();
            dob = new Label();
            pictureBox4 = new PictureBox();
            status = new Label();
            pictureBox5 = new PictureBox();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Frame1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 160);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Poppins", 11F);
            email.Location = new Point(80, 155);
            email.Margin = new Padding(0);
            email.Name = "email";
            email.Size = new Size(219, 39);
            email.TabIndex = 3;
            email.Text = "email@gmail.com";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Font = new Font("Poppins", 11F);
            phoneNumber.Location = new Point(80, 205);
            phoneNumber.Margin = new Padding(0);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(153, 39);
            phoneNumber.TabIndex = 5;
            phoneNumber.Text = "0829440357";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.phone;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(40, 210);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BackgroundImage = Properties.Resources.avatar;
            circularPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            circularPictureBox1.Location = new Point(40, 20);
            circularPictureBox1.Margin = new Padding(0);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(100, 100);
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Location = new Point(20, 138);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 2);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(fullName);
            panel1.Controls.Add(role);
            panel1.Controls.Add(circularPictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 140);
            panel1.TabIndex = 0;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Poppins", 11F);
            gender.Location = new Point(80, 255);
            gender.Margin = new Padding(0);
            gender.Name = "gender";
            gender.Size = new Size(72, 39);
            gender.TabIndex = 7;
            gender.Text = "MALE";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.gender_fluid;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(40, 260);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Font = new Font("Poppins", 11F);
            dob.Location = new Point(80, 305);
            dob.Margin = new Padding(0);
            dob.Name = "dob";
            dob.Size = new Size(147, 39);
            dob.TabIndex = 9;
            dob.Text = "08/04/2003";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.birthday_cake;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(40, 310);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Poppins", 11F);
            status.Location = new Point(80, 355);
            status.Margin = new Padding(0);
            status.Name = "status";
            status.Size = new Size(92, 39);
            status.TabIndex = 11;
            status.Text = "ACTIVE";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.status;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(40, 360);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(20, 420);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(560, 2);
            panel3.TabIndex = 12;
            // 
            // InformationPanel
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(status);
            Controls.Add(pictureBox5);
            Controls.Add(dob);
            Controls.Add(pictureBox4);
            Controls.Add(gender);
            Controls.Add(pictureBox3);
            Controls.Add(phoneNumber);
            Controls.Add(pictureBox2);
            Controls.Add(email);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(0);
            Name = "InformationPanel";
            Size = new Size(600, 1050);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label email;
        private Label phoneNumber;
        private PictureBox pictureBox2;
        private Common.CircularPictureBox circularPictureBox1;
        private Label role;
        private Label fullName;
        private Panel panel2;
        private Panel panel1;
        private Label gender;
        private PictureBox pictureBox3;
        private Label dob;
        private PictureBox pictureBox4;
        private Label status;
        private PictureBox pictureBox5;
        private Panel panel3;
    }
}
