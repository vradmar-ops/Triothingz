namespace Students_Attendance
{
    partial class TeacherDashboard
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
            lblWelcome = new Label();
            btnLogout = new Button();
            tabControl1 = new TabControl();
            tabControl = new TabPage();
            dgvMarkAttendance = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnMarkAllAbsent = new Button();
            btnMarkAllPresent = new Button();
            btnSaveAttendance = new Button();
            lblStudentCount = new Label();
            dtpAttendanceDate = new DateTimePicker();
            label1 = new Label();
            cboSubject = new ComboBox();
            tabPage2 = new TabPage();
            dgvAttendanceHistory = new DataGridView();
            HistoryStudentID = new DataGridViewTextBoxColumn();
            HistoryStudentName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status1 = new DataGridViewTextBoxColumn();
            lblTotalRecords = new Label();
            btnExportHistory = new Button();
            lblSearchStudentNameID = new Label();
            txtSearchStudent = new TextBox();
            btnSearchHistory = new Button();
            dtpToDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dtpFromDate = new DateTimePicker();
            lblSelectSubject = new Label();
            cboHistorySubject = new ComboBox();
            tabPage1 = new TabPage();
            dgvStatistics = new DataGridView();
            StatsStudentID = new DataGridViewTextBoxColumn();
            StatsStudentName = new DataGridViewTextBoxColumn();
            Present = new DataGridViewTextBoxColumn();
            Excused = new DataGridViewTextBoxColumn();
            Late = new DataGridViewTextBoxColumn();
            Absent = new DataGridViewTextBoxColumn();
            AttendanceRate = new DataGridViewTextBoxColumn();
            lblStatsInfo = new Label();
            btnExportStats = new Button();
            btnGenerateStats = new Button();
            label6 = new Label();
            label5 = new Label();
            dtpStatsToDate = new DateTimePicker();
            dtpStatsFromDate = new DateTimePicker();
            label4 = new Label();
            cboStatsSubject = new ComboBox();
            tabControl1.SuspendLayout();
            tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkAttendance).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(298, 37);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(295, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [username]";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(878, 617);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(98, 27);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabControl);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 77);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(988, 503);
            tabControl1.TabIndex = 2;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(dgvMarkAttendance);
            tabControl.Controls.Add(btnMarkAllAbsent);
            tabControl.Controls.Add(btnMarkAllPresent);
            tabControl.Controls.Add(btnSaveAttendance);
            tabControl.Controls.Add(lblStudentCount);
            tabControl.Controls.Add(dtpAttendanceDate);
            tabControl.Controls.Add(label1);
            tabControl.Controls.Add(cboSubject);
            tabControl.Location = new Point(4, 24);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Padding(3);
            tabControl.Size = new Size(980, 475);
            tabControl.TabIndex = 0;
            tabControl.Text = "1. Mark Attendance";
            tabControl.UseVisualStyleBackColor = true;
            // 
            // dgvMarkAttendance
            // 
            dgvMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Status });
            dgvMarkAttendance.Location = new Point(7, 158);
            dgvMarkAttendance.Name = "dgvMarkAttendance";
            dgvMarkAttendance.Size = new Size(346, 163);
            dgvMarkAttendance.TabIndex = 7;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.Name = "StudentName";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // btnMarkAllAbsent
            // 
            btnMarkAllAbsent.Location = new Point(235, 112);
            btnMarkAllAbsent.Name = "btnMarkAllAbsent";
            btnMarkAllAbsent.Size = new Size(110, 28);
            btnMarkAllAbsent.TabIndex = 6;
            btnMarkAllAbsent.Text = "Mark All Absent";
            btnMarkAllAbsent.UseVisualStyleBackColor = true;
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Location = new Point(119, 112);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.Size = new Size(110, 28);
            btnMarkAllPresent.TabIndex = 5;
            btnMarkAllPresent.Text = "Mark All Present";
            btnMarkAllPresent.UseVisualStyleBackColor = true;
            btnMarkAllPresent.Click += btnMarkAllPresent_Click;
            // 
            // btnSaveAttendance
            // 
            btnSaveAttendance.Location = new Point(3, 112);
            btnSaveAttendance.Name = "btnSaveAttendance";
            btnSaveAttendance.Size = new Size(110, 28);
            btnSaveAttendance.TabIndex = 4;
            btnSaveAttendance.Text = "Save Attendance";
            btnSaveAttendance.UseVisualStyleBackColor = true;
            btnSaveAttendance.Click += btnSaveAttendance_Click;
            // 
            // lblStudentCount
            // 
            lblStudentCount.AutoSize = true;
            lblStudentCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentCount.Location = new Point(7, 84);
            lblStudentCount.Name = "lblStudentCount";
            lblStudentCount.Size = new Size(149, 25);
            lblStudentCount.TabIndex = 3;
            lblStudentCount.Text = "Total Students: X";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(7, 58);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(243, 23);
            dtpAttendanceDate.TabIndex = 2;
            dtpAttendanceDate.ValueChanged += dtpAttendanceDate_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 27);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 1;
            label1.Text = "Select Subjects:";
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(129, 29);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(121, 23);
            cboSubject.TabIndex = 0;
            cboSubject.SelectedIndexChanged += cboSubject_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAttendanceHistory);
            tabPage2.Controls.Add(lblTotalRecords);
            tabPage2.Controls.Add(btnExportHistory);
            tabPage2.Controls.Add(lblSearchStudentNameID);
            tabPage2.Controls.Add(txtSearchStudent);
            tabPage2.Controls.Add(btnSearchHistory);
            tabPage2.Controls.Add(dtpToDate);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dtpFromDate);
            tabPage2.Controls.Add(lblSelectSubject);
            tabPage2.Controls.Add(cboHistorySubject);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(980, 475);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. View History";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvAttendanceHistory
            // 
            dgvAttendanceHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendanceHistory.Columns.AddRange(new DataGridViewColumn[] { HistoryStudentID, HistoryStudentName, Date, Status1 });
            dgvAttendanceHistory.Location = new Point(3, 183);
            dgvAttendanceHistory.Name = "dgvAttendanceHistory";
            dgvAttendanceHistory.Size = new Size(445, 238);
            dgvAttendanceHistory.TabIndex = 11;
            dgvAttendanceHistory.CellContentClick += dataGridView2_CellContentClick;
            // 
            // HistoryStudentID
            // 
            HistoryStudentID.HeaderText = "History Student ID ";
            HistoryStudentID.Name = "HistoryStudentID";
            // 
            // HistoryStudentName
            // 
            HistoryStudentName.HeaderText = "History Student Name ";
            HistoryStudentName.Name = "HistoryStudentName";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Status1
            // 
            Status1.HeaderText = "Status1";
            Status1.Name = "Status1";
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecords.Location = new Point(170, 155);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(143, 25);
            lblTotalRecords.TabIndex = 10;
            lblTotalRecords.Text = "Total Records: X";
            // 
            // btnExportHistory
            // 
            btnExportHistory.Location = new Point(7, 119);
            btnExportHistory.Name = "btnExportHistory";
            btnExportHistory.Size = new Size(93, 23);
            btnExportHistory.TabIndex = 9;
            btnExportHistory.Text = "Export to CSV";
            btnExportHistory.UseVisualStyleBackColor = true;
            btnExportHistory.Click += btnExportHistory_Click;
            // 
            // lblSearchStudentNameID
            // 
            lblSearchStudentNameID.AutoSize = true;
            lblSearchStudentNameID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchStudentNameID.Location = new Point(7, 83);
            lblSearchStudentNameID.Name = "lblSearchStudentNameID";
            lblSearchStudentNameID.Size = new Size(184, 21);
            lblSearchStudentNameID.TabIndex = 8;
            lblSearchStudentNameID.Text = "Search Student Name/ID:";
            lblSearchStudentNameID.Click += lblSearchStudentNameID_Click;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.BackColor = SystemColors.Info;
            txtSearchStudent.Location = new Point(197, 85);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(294, 23);
            txtSearchStudent.TabIndex = 7;
            txtSearchStudent.TextChanged += txtSearchStudent_TextChanged;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.Location = new Point(416, 119);
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.Size = new Size(75, 23);
            btnSearchHistory.TabIndex = 6;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.UseVisualStyleBackColor = true;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(291, 54);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(200, 23);
            dtpToDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(257, 54);
            label3.Name = "label3";
            label3.Size = new Size(28, 21);
            label3.TabIndex = 4;
            label3.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 52);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 3;
            label2.Text = "From:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(51, 52);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(200, 23);
            dtpFromDate.TabIndex = 2;
            // 
            // lblSelectSubject
            // 
            lblSelectSubject.AutoSize = true;
            lblSelectSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectSubject.Location = new Point(6, 21);
            lblSelectSubject.Name = "lblSelectSubject";
            lblSelectSubject.Size = new Size(109, 21);
            lblSelectSubject.TabIndex = 1;
            lblSelectSubject.Text = "Select Subject:";
            // 
            // cboHistorySubject
            // 
            cboHistorySubject.FormattingEnabled = true;
            cboHistorySubject.Location = new Point(121, 23);
            cboHistorySubject.Name = "cboHistorySubject";
            cboHistorySubject.Size = new Size(121, 23);
            cboHistorySubject.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvStatistics);
            tabPage1.Controls.Add(lblStatsInfo);
            tabPage1.Controls.Add(btnExportStats);
            tabPage1.Controls.Add(btnGenerateStats);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dtpStatsToDate);
            tabPage1.Controls.Add(dtpStatsFromDate);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cboStatsSubject);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(980, 475);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "3. Statistics";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvStatistics
            // 
            dgvStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStatistics.Columns.AddRange(new DataGridViewColumn[] { StatsStudentID, StatsStudentName, Present, Excused, Late, Absent, AttendanceRate });
            dgvStatistics.Location = new Point(7, 137);
            dgvStatistics.Name = "dgvStatistics";
            dgvStatistics.Size = new Size(750, 238);
            dgvStatistics.TabIndex = 9;
            // 
            // StatsStudentID
            // 
            StatsStudentID.HeaderText = "Stats Student ID";
            StatsStudentID.Name = "StatsStudentID";
            // 
            // StatsStudentName
            // 
            StatsStudentName.HeaderText = "Stats Student Name";
            StatsStudentName.Name = "StatsStudentName";
            // 
            // Present
            // 
            Present.HeaderText = "Present";
            Present.Name = "Present";
            // 
            // Excused
            // 
            Excused.HeaderText = "Excused";
            Excused.Name = "Excused";
            // 
            // Late
            // 
            Late.HeaderText = "Late";
            Late.Name = "Late";
            // 
            // Absent
            // 
            Absent.HeaderText = "Absent";
            Absent.Name = "Absent";
            // 
            // AttendanceRate
            // 
            AttendanceRate.HeaderText = "Attendance Rate";
            AttendanceRate.Name = "AttendanceRate";
            // 
            // lblStatsInfo
            // 
            lblStatsInfo.AutoSize = true;
            lblStatsInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatsInfo.Location = new Point(329, 113);
            lblStatsInfo.Name = "lblStatsInfo";
            lblStatsInfo.Size = new Size(97, 21);
            lblStatsInfo.TabIndex = 8;
            lblStatsInfo.Text = "Statistic Info:";
            // 
            // btnExportStats
            // 
            btnExportStats.Location = new Point(7, 81);
            btnExportStats.Name = "btnExportStats";
            btnExportStats.Size = new Size(117, 23);
            btnExportStats.TabIndex = 7;
            btnExportStats.Text = "Export to CSV";
            btnExportStats.UseVisualStyleBackColor = true;
            btnExportStats.Click += btnExportStats_Click;
            // 
            // btnGenerateStats
            // 
            btnGenerateStats.Location = new Point(386, 81);
            btnGenerateStats.Name = "btnGenerateStats";
            btnGenerateStats.Size = new Size(117, 23);
            btnGenerateStats.TabIndex = 6;
            btnGenerateStats.Text = "Generate Stastistic";
            btnGenerateStats.UseVisualStyleBackColor = true;
            btnGenerateStats.Click += btnGenerateStats_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(269, 52);
            label6.Name = "label6";
            label6.Size = new Size(28, 21);
            label6.TabIndex = 5;
            label6.Text = "To:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 50);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 4;
            label5.Text = "From:";
            // 
            // dtpStatsToDate
            // 
            dtpStatsToDate.Location = new Point(303, 52);
            dtpStatsToDate.Name = "dtpStatsToDate";
            dtpStatsToDate.Size = new Size(200, 23);
            dtpStatsToDate.TabIndex = 3;
            // 
            // dtpStatsFromDate
            // 
            dtpStatsFromDate.Location = new Point(63, 50);
            dtpStatsFromDate.Name = "dtpStatsFromDate";
            dtpStatsFromDate.Size = new Size(200, 23);
            dtpStatsFromDate.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 21);
            label4.Name = "label4";
            label4.Size = new Size(109, 21);
            label4.TabIndex = 1;
            label4.Text = "Select Subject:";
            // 
            // cboStatsSubject
            // 
            cboStatsSubject.FormattingEnabled = true;
            cboStatsSubject.Location = new Point(126, 19);
            cboStatsSubject.Name = "cboStatsSubject";
            cboStatsSubject.Size = new Size(121, 23);
            cboStatsSubject.TabIndex = 0;
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 672);
            Controls.Add(tabControl1);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "TeacherDashboard";
            Text = "TeacherDashboard";
            Load += TeacherDashboard_Load;
            tabControl1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarkAttendance).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceHistory).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabControl1;
        private TabPage tabControl;
        private TabPage tabPage2;
        private Label lblStudentCount;
        private DateTimePicker dtpAttendanceDate;
        private Label label1;
        private ComboBox cboSubject;
        private TabPage tabPage1;
        private Button btnSaveAttendance;
        private DataGridView dgvMarkAttendance;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Status;
        private Button btnMarkAllAbsent;
        private Button btnMarkAllPresent;
        private Label lblSearchStudentNameID;
        private TextBox txtSearchStudent;
        private Button btnSearchHistory;
        private DateTimePicker dtpToDate;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFromDate;
        private Label lblSelectSubject;
        private ComboBox cboHistorySubject;
        private DataGridView dgvAttendanceHistory;
        private Label lblTotalRecords;
        private Button btnExportHistory;
        private DataGridViewTextBoxColumn HistoryStudentID;
        private DataGridViewTextBoxColumn HistoryStudentName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status1;
        private Label lblStatsInfo;
        private Button btnExportStats;
        private Button btnGenerateStats;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpStatsToDate;
        private DateTimePicker dtpStatsFromDate;
        private Label label4;
        private ComboBox cboStatsSubject;
        private DataGridView dgvStatistics;
        private DataGridViewTextBoxColumn StatsStudentID;
        private DataGridViewTextBoxColumn StatsStudentName;
        private DataGridViewTextBoxColumn Present;
        private DataGridViewTextBoxColumn Excused;
        private DataGridViewTextBoxColumn Late;
        private DataGridViewTextBoxColumn Absent;
        private DataGridViewTextBoxColumn AttendanceRate;
    }
}