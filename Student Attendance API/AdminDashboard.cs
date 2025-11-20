using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Students_Attendance
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {UserSession.Username}";

            // Load initial data
            LoadStudents();
            LoadTeachers();
            LoadSubjects();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string studentID = txtStudentID.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentID))
            {
                MessageBox.Show("Please enter both Student Name and Student ID.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            // For now, add to DataGridView
            dgvStudents.Rows.Add(studentID, studentName, DateTime.Now.ToString("yyyy-MM-dd"));

            MessageBox.Show("Student added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs
            txtStudentName.Clear();
            txtStudentID.Clear();
            txtStudentName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvStudents.SelectedRows[0];
            txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
            txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TODO: Delete from database
                dgvStudents.Rows.RemoveAt(dgvStudents.SelectedRows[0].Index);
                MessageBox.Show("Student deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadStudents()
        {
            // TODO: Load from database
            // Sample data
            dgvStudents.Rows.Clear();
            dgvStudents.Rows.Add("2024001", "John Doe", "2025-11-18");
            dgvStudents.Rows.Add("2024002", "Jane Smith", "2025-11-18");
            dgvStudents.Rows.Add("2024003", "Mike Johnson", "2025-11-18");
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string teacherName = txtTeacherName.Text.Trim();
            string username = txtTeacherUsername.Text.Trim();
            string password = txtTeacherPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(teacherName) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all teacher fields.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            dgvTeachers.Rows.Add(username, teacherName, "Active");

            MessageBox.Show("Teacher added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs
            txtTeacherName.Clear();
            txtTeacherUsername.Clear();
            txtTeacherPassword.Clear();
            txtTeacherName.Focus();
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this teacher?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TODO: Delete from database
                dgvTeachers.Rows.RemoveAt(dgvTeachers.SelectedRows[0].Index);
                MessageBox.Show("Teacher deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadTeachers()
        {
            // TODO: Load from database
            dgvTeachers.Rows.Clear();
            dgvTeachers.Rows.Add("teacher1", "Prof. Sarah Williams", "Active");
            dgvTeachers.Rows.Add("teacher2", "Prof. Mark Davis", "Active");
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this subject?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TODO: Delete from database
                dgvSubjects.Rows.RemoveAt(dgvSubjects.SelectedRows[0].Index);
                MessageBox.Show("Subject deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string subjectCode = txtSubjectCode.Text.Trim();
            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrWhiteSpace(subjectCode) || string.IsNullOrWhiteSpace(subjectName))
            {
                MessageBox.Show("Please enter both Subject Code and Subject Name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Insert into database
            dgvSubjects.Rows.Add(subjectCode, subjectName);

            MessageBox.Show("Subject added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs
            txtSubjectCode.Clear();
            txtSubjectName.Clear();
            txtSubjectCode.Focus();
        }
        private void LoadSubjects()
        {
            // TODO: Load from database
            dgvSubjects.Rows.Clear();
            dgvSubjects.Rows.Add("CS101", "Introduction to Programming");
            dgvSubjects.Rows.Add("MATH101", "Calculus I");
            dgvSubjects.Rows.Add("ENG101", "English Composition");
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cboAssignTeacher.SelectedItem == null ||
                cboAssignSubject.SelectedItem == null ||
                lstAvailableStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher, subject, and at least one student.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string teacher = cboAssignTeacher.SelectedItem.ToString();
            string subject = cboAssignSubject.SelectedItem.ToString();

            foreach (var item in lstAvailableStudents.SelectedItems)
            {
                // TODO: Insert into database
                dgvAssignments.Rows.Add(item.ToString(), subject, teacher);
            }

            MessageBox.Show($"Assigned {lstAvailableStudents.SelectedItems.Count} student(s) successfully!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lstAvailableStudents.ClearSelected();
        }

        private void btnRemoveAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to remove this assignment?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // TODO: Delete from database
                dgvAssignments.Rows.RemoveAt(dgvAssignments.SelectedRows[0].Index);
                MessageBox.Show("Assignment removed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstAvailableStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableStudents();
        }
        private void LoadAvailableStudents()
        {
            // TODO: Load from database (students not already assigned to this subject)
            lstAvailableStudents.Items.Clear();
            lstAvailableStudents.Items.Add("John Doe (2024001)");
            lstAvailableStudents.Items.Add("Jane Smith (2024002)");
            lstAvailableStudents.Items.Add("Mike Johnson (2024003)");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                // Show login form again
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }
    }
}

