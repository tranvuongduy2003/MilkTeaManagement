namespace MilkTeaManagement.WindowsApp.UserControls.Employees
{
    partial class WorkDays
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            WorkDaysDataGridView = new DataGridView();
            Save = new Button();
            Id = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Monday = new DataGridViewCheckBoxColumn();
            Tuesday = new DataGridViewCheckBoxColumn();
            Wednesday = new DataGridViewCheckBoxColumn();
            Thursday = new DataGridViewCheckBoxColumn();
            Friday = new DataGridViewCheckBoxColumn();
            Saturday = new DataGridViewCheckBoxColumn();
            Sunday = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)WorkDaysDataGridView).BeginInit();
            SuspendLayout();
            // 
            // WorkDaysDataGridView
            // 
            WorkDaysDataGridView.AllowUserToAddRows = false;
            WorkDaysDataGridView.AllowUserToDeleteRows = false;
            WorkDaysDataGridView.BackgroundColor = Color.White;
            WorkDaysDataGridView.BorderStyle = BorderStyle.None;
            WorkDaysDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Poppins", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            WorkDaysDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            WorkDaysDataGridView.ColumnHeadersHeight = 50;
            WorkDaysDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            WorkDaysDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Time, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday });
            WorkDaysDataGridView.GridColor = Color.Black;
            WorkDaysDataGridView.Location = new Point(0, 60);
            WorkDaysDataGridView.Margin = new Padding(0);
            WorkDaysDataGridView.Name = "WorkDaysDataGridView";
            WorkDaysDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            WorkDaysDataGridView.RowHeadersVisible = false;
            WorkDaysDataGridView.RowHeadersWidth = 62;
            WorkDaysDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            WorkDaysDataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Poppins", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WorkDaysDataGridView.RowTemplate.Height = 265;
            WorkDaysDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            WorkDaysDataGridView.ScrollBars = ScrollBars.None;
            WorkDaysDataGridView.Size = new Size(1180, 845);
            WorkDaysDataGridView.TabIndex = 0;
            // 
            // Save
            // 
            Save.AutoSize = true;
            Save.BackColor = Color.DodgerBlue;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Poppins Medium", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save.ForeColor = Color.White;
            Save.Location = new Point(0, 0);
            Save.Margin = new Padding(0);
            Save.Name = "Save";
            Save.Size = new Size(112, 51);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 150;
            // 
            // Time
            // 
            Time.HeaderText = "";
            Time.MinimumWidth = 8;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 150;
            // 
            // Monday
            // 
            Monday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Monday.HeaderText = "Monday";
            Monday.MinimumWidth = 8;
            Monday.Name = "Monday";
            Monday.Resizable = DataGridViewTriState.True;
            Monday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Tuesday
            // 
            Tuesday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tuesday.HeaderText = "Tuesday";
            Tuesday.MinimumWidth = 8;
            Tuesday.Name = "Tuesday";
            Tuesday.Resizable = DataGridViewTriState.True;
            Tuesday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Wednesday
            // 
            Wednesday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Wednesday.HeaderText = "Wednesday";
            Wednesday.MinimumWidth = 8;
            Wednesday.Name = "Wednesday";
            Wednesday.Resizable = DataGridViewTriState.True;
            Wednesday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Thursday
            // 
            Thursday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thursday.HeaderText = "Thursday";
            Thursday.MinimumWidth = 8;
            Thursday.Name = "Thursday";
            Thursday.Resizable = DataGridViewTriState.True;
            Thursday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Friday
            // 
            Friday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Friday.HeaderText = "Friday";
            Friday.MinimumWidth = 8;
            Friday.Name = "Friday";
            Friday.Resizable = DataGridViewTriState.True;
            Friday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Saturday
            // 
            Saturday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Saturday.HeaderText = "Saturday";
            Saturday.MinimumWidth = 8;
            Saturday.Name = "Saturday";
            Saturday.Resizable = DataGridViewTriState.True;
            Saturday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Sunday
            // 
            Sunday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sunday.HeaderText = "Sunday";
            Sunday.MinimumWidth = 8;
            Sunday.Name = "Sunday";
            Sunday.Resizable = DataGridViewTriState.True;
            Sunday.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // WorkDays
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(Save);
            Controls.Add(WorkDaysDataGridView);
            Margin = new Padding(0);
            Name = "WorkDays";
            Size = new Size(1180, 905);
            ((System.ComponentModel.ISupportInitialize)WorkDaysDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView WorkDaysDataGridView;
        private Button Save;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewCheckBoxColumn Monday;
        private DataGridViewCheckBoxColumn Tuesday;
        private DataGridViewCheckBoxColumn Wednesday;
        private DataGridViewCheckBoxColumn Thursday;
        private DataGridViewCheckBoxColumn Friday;
        private DataGridViewCheckBoxColumn Saturday;
        private DataGridViewCheckBoxColumn Sunday;
    }
}
