namespace Students_Attendance
{
    partial class AdminDashboard
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
            tabPage1 = new TabPage();
            dgvStudents = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            DateEnrolled = new DataGridViewTextBoxColumn();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAddStudent = new Button();
            txtStudentName = new TextBox();
            lblStudentName = new Label();
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            tabPage2 = new TabPage();
            dgvTeachers = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            TeacherName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnDeleteTeacher = new Button();
            btnAddTeacher = new Button();
            lblTeacherPassword = new Label();
            txtTeacherPassword = new TextBox();
            txtTeacherUsername = new TextBox();
            lblTeacherUsername = new Label();
            lblTeacherName = new Label();
            txtTeacherName = new TextBox();
            tabPage3 = new TabPage();
            dgvSubjects = new DataGridView();
            SubjectCode = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            btnDeleteSubject = new Button();
            btnAddSubject = new Button();
            txtSubjectName = new TextBox();
            lblSubjectName = new Label();
            txtSubjectCode = new TextBox();
            lblSubjectCode = new Label();
            tabPage4 = new TabPage();
            dgvAssignments = new DataGridView();
            StudentName1 = new DataGridViewTextBoxColumn();
            SubjectName1 = new DataGridViewTextBoxColumn();
            TeacherName1 = new DataGridViewTextBoxColumn();
            btnRemoveAssignment = new Button();
            btnAssign = new Button();
            lstAvailableStudents = new ListBox();
            lblAssignSubjects = new Label();
            cboAssignSubject = new ComboBox();
            lblAssignTeachers = new Label();
            cboAssignTeacher = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(317, 21);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(295, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, [username]";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(871, 594);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 28);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 506);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvStudents);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnEdit);
            tabPage1.Controls.Add(btnAddStudent);
            tabPage1.Controls.Add(txtStudentName);
            tabPage1.Controls.Add(lblStudentName);
            tabPage1.Controls.Add(lblStudentID);
            tabPage1.Controls.Add(txtStudentID);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. Students Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, DateEnrolled });
            dgvStudents.Location = new Point(6, 142);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(346, 150);
            dgvStudents.TabIndex = 8;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "StudentID:";
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name:";
            StudentName.Name = "StudentName";
            // 
            // DateEnrolled
            // 
            DateEnrolled.HeaderText = "Date Enrolled:";
            DateEnrolled.Name = "DateEnrolled";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(188, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(94, 100);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(6, 100);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(75, 23);
            btnAddStudent.TabIndex = 5;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = SystemColors.Info;
            txtStudentName.Location = new Point(121, 60);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(218, 23);
            txtStudentName.TabIndex = 3;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(3, 58);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(112, 21);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Student Name:";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.Location = new Point(3, 25);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(85, 21);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "Student ID:";
            lblStudentID.Click += lblStudentID_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = SystemColors.Info;
            txtStudentID.Location = new Point(94, 23);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(245, 23);
            txtStudentID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvTeachers);
            tabPage2.Controls.Add(btnDeleteTeacher);
            tabPage2.Controls.Add(btnAddTeacher);
            tabPage2.Controls.Add(lblTeacherPassword);
            tabPage2.Controls.Add(txtTeacherPassword);
            tabPage2.Controls.Add(txtTeacherUsername);
            tabPage2.Controls.Add(lblTeacherUsername);
            tabPage2.Controls.Add(lblTeacherName);
            tabPage2.Controls.Add(txtTeacherName);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(975, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. Teachers Management";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { Username, TeacherName, Status });
            dgvTeachers.Location = new Point(8, 205);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.Size = new Size(344, 254);
            dgvTeachers.TabIndex = 8;
            // 
            // Username
            // 
            Username.HeaderText = "Username:";
            Username.Name = "Username";
            // 
            // TeacherName
            // 
            TeacherName.HeaderText = "Teacher Name:";
            TeacherName.Name = "TeacherName";
            // 
            // Status
            // 
            Status.HeaderText = "Status:";
            Status.Name = "Status";
            // 
            // btnDeleteTeacher
            // 
            btnDeleteTeacher.Location = new Point(305, 156);
            btnDeleteTeacher.Name = "btnDeleteTeacher";
            btnDeleteTeacher.Size = new Size(75, 23);
            btnDeleteTeacher.TabIndex = 7;
            btnDeleteTeacher.Text = "Delete";
            btnDeleteTeacher.UseVisualStyleBackColor = true;
            btnDeleteTeacher.Click += btnDeleteTeacher_Click;
            // 
            // btnAddTeacher
            // 
            btnAddTeacher.Location = new Point(224, 156);
            btnAddTeacher.Name = "btnAddTeacher";
            btnAddTeacher.Size = new Size(75, 23);
            btnAddTeacher.TabIndex = 6;
            btnAddTeacher.Text = "Add";
            btnAddTeacher.UseVisualStyleBackColor = true;
            btnAddTeacher.Click += btnAddTeacher_Click;
            // 
            // lblTeacherPassword
            // 
            lblTeacherPassword.AutoSize = true;
            lblTeacherPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherPassword.Location = new Point(8, 113);
            lblTeacherPassword.Name = "lblTeacherPassword";
            lblTeacherPassword.Size = new Size(135, 21);
            lblTeacherPassword.TabIndex = 5;
            lblTeacherPassword.Text = "Teacher Password:";
            // 
            // txtTeacherPassword
            // 
            txtTeacherPassword.BackColor = SystemColors.Info;
            txtTeacherPassword.Location = new Point(154, 115);
            txtTeacherPassword.Name = "txtTeacherPassword";
            txtTeacherPassword.PasswordChar = '*';
            txtTeacherPassword.Size = new Size(226, 23);
            txtTeacherPassword.TabIndex = 4;
            // 
            // txtTeacherUsername
            // 
            txtTeacherUsername.BackColor = SystemColors.Info;
            txtTeacherUsername.Location = new Point(154, 70);
            txtTeacherUsername.Name = "txtTeacherUsername";
            txtTeacherUsername.Size = new Size(226, 23);
            txtTeacherUsername.TabIndex = 3;
            // 
            // lblTeacherUsername
            // 
            lblTeacherUsername.AutoSize = true;
            lblTeacherUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherUsername.Location = new Point(8, 68);
            lblTeacherUsername.Name = "lblTeacherUsername";
            lblTeacherUsername.Size = new Size(140, 21);
            lblTeacherUsername.TabIndex = 2;
            lblTeacherUsername.Text = "Teacher Username:";
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTeacherName.Location = new Point(8, 25);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(111, 21);
            lblTeacherName.TabIndex = 1;
            lblTeacherName.Text = "Teacher Name:";
            // 
            // txtTeacherName
            // 
            txtTeacherName.BackColor = SystemColors.Info;
            txtTeacherName.Location = new Point(125, 27);
            txtTeacherName.Name = "txtTeacherName";
            txtTeacherName.Size = new Size(255, 23);
            txtTeacherName.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvSubjects);
            tabPage3.Controls.Add(btnDeleteSubject);
            tabPage3.Controls.Add(btnAddSubject);
            tabPage3.Controls.Add(txtSubjectName);
            tabPage3.Controls.Add(lblSubjectName);
            tabPage3.Controls.Add(txtSubjectCode);
            tabPage3.Controls.Add(lblSubjectCode);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(975, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3. Subjects Management";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Columns.AddRange(new DataGridViewColumn[] { SubjectCode, SubjectName });
            dgvSubjects.Location = new Point(18, 187);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(242, 150);
            dgvSubjects.TabIndex = 6;
            // 
            // SubjectCode
            // 
            SubjectCode.HeaderText = "Subject Code";
            SubjectCode.Name = "SubjectCode";
            // 
            // SubjectName
            // 
            SubjectName.HeaderText = "Subject Name";
            SubjectName.Name = "SubjectName";
            // 
            // btnDeleteSubject
            // 
            btnDeleteSubject.Location = new Point(144, 139);
            btnDeleteSubject.Name = "btnDeleteSubject";
            btnDeleteSubject.Size = new Size(75, 23);
            btnDeleteSubject.TabIndex = 5;
            btnDeleteSubject.Text = "Delete";
            btnDeleteSubject.UseVisualStyleBackColor = true;
            btnDeleteSubject.Click += btnDeleteSubject_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(225, 139);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(75, 23);
            btnAddSubject.TabIndex = 4;
            btnAddSubject.Text = "Add";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // txtSubjectName
            // 
            txtSubjectName.BackColor = SystemColors.Info;
            txtSubjectName.Location = new Point(128, 86);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(172, 23);
            txtSubjectName.TabIndex = 3;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectName.Location = new Point(18, 84);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(110, 21);
            lblSubjectName.TabIndex = 2;
            lblSubjectName.Text = "Subject Name:";
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.BackColor = SystemColors.Info;
            txtSubjectCode.Location = new Point(128, 37);
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(172, 23);
            txtSubjectCode.TabIndex = 1;
            // 
            // lblSubjectCode
            // 
            lblSubjectCode.AutoSize = true;
            lblSubjectCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectCode.Location = new Point(18, 37);
            lblSubjectCode.Name = "lblSubjectCode";
            lblSubjectCode.Size = new Size(104, 21);
            lblSubjectCode.TabIndex = 0;
            lblSubjectCode.Text = "Subject Code:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvAssignments);
            tabPage4.Controls.Add(btnRemoveAssignment);
            tabPage4.Controls.Add(btnAssign);
            tabPage4.Controls.Add(lstAvailableStudents);
            tabPage4.Controls.Add(lblAssignSubjects);
            tabPage4.Controls.Add(cboAssignSubject);
            tabPage4.Controls.Add(lblAssignTeachers);
            tabPage4.Controls.Add(cboAssignTeacher);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(975, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "4. Assign Students to Subjects";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Columns.AddRange(new DataGridViewColumn[] { StudentName1, SubjectName1, TeacherName1 });
            dgvAssignments.Location = new Point(8, 176);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.Size = new Size(343, 150);
            dgvAssignments.TabIndex = 7;
            // 
            // StudentName1
            // 
            StudentName1.HeaderText = "Student Name";
            StudentName1.Name = "StudentName1";
            // 
            // SubjectName1
            // 
            SubjectName1.HeaderText = "Subject Name";
            SubjectName1.Name = "SubjectName1";
            // 
            // TeacherName1
            // 
            TeacherName1.HeaderText = "Teacher Name";
            TeacherName1.Name = "TeacherName1";
            // 
            // btnRemoveAssignment
            // 
            btnRemoveAssignment.Location = new Point(115, 99);
            btnRemoveAssignment.Name = "btnRemoveAssignment";
            btnRemoveAssignment.Size = new Size(75, 23);
            btnRemoveAssignment.TabIndex = 6;
            btnRemoveAssignment.Text = "Remove";
            btnRemoveAssignment.UseVisualStyleBackColor = true;
            btnRemoveAssignment.Click += btnRemoveAssignment_Click;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(196, 99);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(75, 23);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // lstAvailableStudents
            // 
            lstAvailableStudents.FormattingEnabled = true;
            lstAvailableStudents.Location = new Point(288, 41);
            lstAvailableStudents.Name = "lstAvailableStudents";
            lstAvailableStudents.SelectionMode = SelectionMode.MultiExtended;
            lstAvailableStudents.Size = new Size(172, 49);
            lstAvailableStudents.TabIndex = 4;
            lstAvailableStudents.SelectedIndexChanged += lstAvailableStudents_SelectedIndexChanged;
            // 
            // lblAssignSubjects
            // 
            lblAssignSubjects.AutoSize = true;
            lblAssignSubjects.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssignSubjects.Location = new Point(8, 72);
            lblAssignSubjects.Name = "lblAssignSubjects";
            lblAssignSubjects.Size = new Size(114, 21);
            lblAssignSubjects.TabIndex = 3;
            lblAssignSubjects.Text = "Assign Subject:";
            lblAssignSubjects.Click += label1_Click;
            // 
            // cboAssignSubject
            // 
            cboAssignSubject.FormattingEnabled = true;
            cboAssignSubject.Location = new Point(136, 70);
            cboAssignSubject.Name = "cboAssignSubject";
            cboAssignSubject.Size = new Size(121, 23);
            cboAssignSubject.TabIndex = 2;
            // 
            // lblAssignTeachers
            // 
            lblAssignTeachers.AutoSize = true;
            lblAssignTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssignTeachers.Location = new Point(8, 39);
            lblAssignTeachers.Name = "lblAssignTeachers";
            lblAssignTeachers.Size = new Size(115, 21);
            lblAssignTeachers.TabIndex = 1;
            lblAssignTeachers.Text = "Assign Teacher:";
            // 
            // cboAssignTeacher
            // 
            cboAssignTeacher.FormattingEnabled = true;
            cboAssignTeacher.Location = new Point(136, 41);
            cboAssignTeacher.Name = "cboAssignTeacher";
            cboAssignTeacher.Size = new Size(121, 23);
            cboAssignTeacher.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(tabControl1);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblStudentID;
        private TextBox txtStudentID;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAddStudent;
        private TextBox txtStudentName;
        private Label lblStudentName;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn DateEnrolled;
        private TextBox txtTeacherName;
        private Button btnAddTeacher;
        private Label lblTeacherPassword;
        private TextBox txtTeacherPassword;
        private TextBox txtTeacherUsername;
        private Label lblTeacherUsername;
        private Label lblTeacherName;
        private DataGridView dgvTeachers;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn TeacherName;
        private DataGridViewTextBoxColumn Status;
        private Button btnDeleteTeacher;
        private DataGridView dgvSubjects;
        private Button btnDeleteSubject;
        private Button btnAddSubject;
        private TextBox txtSubjectName;
        private Label lblSubjectName;
        private TextBox txtSubjectCode;
        private Label lblSubjectCode;
        private DataGridViewTextBoxColumn SubjectCode;
        private DataGridViewTextBoxColumn SubjectName;
        private Label lblAssignSubjects;
        private ComboBox cboAssignSubject;
        private Label lblAssignTeachers;
        private ComboBox cboAssignTeacher;
        private Button btnAssign;
        private ListBox lstAvailableStudents;
        private DataGridView dgvAssignments;
        private DataGridViewTextBoxColumn StudentName1;
        private DataGridViewTextBoxColumn SubjectName1;
        private DataGridViewTextBoxColumn TeacherName1;
        private Button btnRemoveAssignment;
    }
}