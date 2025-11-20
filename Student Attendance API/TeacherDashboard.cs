using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Students_Attendance
{
    public partial class TeacherDashboard : Form
    {
        private string selectedSubject = "";
        private DateTime selectedDate = DateTime.Now;

        public TeacherDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            // Display welcome message
            lblWelcome.Text = $"Welcome, {UserSession.Username}";

            // Set default date to today
            dtpAttendanceDate.Value = DateTime.Now;

            // Load teacher's subjects
            LoadTeacherSubjects();
        }
        private void LoadTeacherSubjects()
        {
            // TODO: Load from database - subjects assigned to this teacher
            cboSubject.Items.Clear();
            cboSubject.Items.Add("CS101 - Introduction to Programming");
            cboSubject.Items.Add("MATH101 - Calculus I");
            cboSubject.Items.Add("ENG101 - English Composition");
        }

        private void LoadStudentsForAttendance()
        {
            // TODO: Load from database - students enrolled in this subject
            // Check if attendance already marked for this date
            dgvMarkAttendance.Rows.Clear();

            // Sample data
            dgvMarkAttendance.Rows.Add("2024001", "John Doe", "Present");
            dgvMarkAttendance.Rows.Add("2024002", "Jane Smith", "Present");
            dgvMarkAttendance.Rows.Add("2024003", "Mike Johnson", "Present");
            dgvMarkAttendance.Rows.Add("2024004", "Sarah Brown", "Present");
            dgvMarkAttendance.Rows.Add("2024005", "Tom Wilson", "Present");

            lblStudentCount.Text = $"Total Students: {dgvMarkAttendance.Rows.Count}";
        }

        private void cboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubject.SelectedItem != null)
            {
                selectedSubject = cboSubject.SelectedItem.ToString();
                LoadStudentsForAttendance();
            }
        }

        private void dtpAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpAttendanceDate.Value;
            if (!string.IsNullOrEmpty(selectedSubject))
            {
                LoadStudentsForAttendance();
            }
        }

        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if (cboSubject.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject first.",
                    "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvMarkAttendance.Rows.Count == 0)
            {
                MessageBox.Show("No students to mark attendance for.",
                    "No Students", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Save to database
            int presentCount = 0;
            int absentCount = 0;
            int lateCount = 0;
            int excusedCount = 0;

            foreach (DataGridViewRow row in dgvMarkAttendance.Rows)
            {
                if (row.IsNewRow) continue;

                string studentID = row.Cells["StudentID"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                // Count attendance status
                switch (status)
                {
                    case "Present": presentCount++; break;
                    case "Absent": absentCount++; break;
                    case "Late": lateCount++; break;
                    case "Excused": excusedCount++; break;
                }

                // TODO: Insert/Update attendance record in database
                // INSERT INTO Attendance (StudentID, SubjectCode, Date, Status, MarkedBy)
                // VALUES (studentID, selectedSubject, selectedDate, status, UserSession.Username)
            }

            MessageBox.Show($"Attendance saved successfully!\n\n" +
                $"Present: {presentCount}\n" +
                $"Absent: {absentCount}\n" +
                $"Late: {lateCount}\n" +
                $"Excused: {excusedCount}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMarkAllPresent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMarkAttendance.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["Status"].Value = "Present";
            }
        }

        private void btnMarkAllAbsent_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to mark all students as Absent?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvMarkAttendance.Rows)
                {
                    if (row.IsNewRow) continue;
                    row.Cells["Status"].Value = "Absent";
                }
            }
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            if (cboHistorySubject.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject.",
                    "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadAttendanceHistory();
        }
        private void LoadAttendanceHistory()
        {
            // TODO: Load from database
            dgvAttendanceHistory.Rows.Clear();

            string subject = cboHistorySubject.SelectedItem.ToString();
            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;

            // Sample data
            dgvAttendanceHistory.Rows.Add("2024001", "John Doe", "2024-11-15", "Present");
            dgvAttendanceHistory.Rows.Add("2024001", "John Doe", "2024-11-16", "Present");
            dgvAttendanceHistory.Rows.Add("2024001", "John Doe", "2024-11-17", "Late");
            dgvAttendanceHistory.Rows.Add("2024002", "Jane Smith", "2024-11-15", "Present");
            dgvAttendanceHistory.Rows.Add("2024002", "Jane Smith", "2024-11-16", "Absent");
            dgvAttendanceHistory.Rows.Add("2024002", "Jane Smith", "2024-11-17", "Excused");
            dgvAttendanceHistory.Rows.Add("2024003", "Mike Johnson", "2024-11-15", "Present");
            dgvAttendanceHistory.Rows.Add("2024003", "Mike Johnson", "2024-11-16", "Present");
            dgvAttendanceHistory.Rows.Add("2024003", "Mike Johnson", "2024-11-17", "Present");

            lblTotalRecords.Text = $"Total Records: {dgvAttendanceHistory.Rows.Count}";
        }

        private void btnExportHistory_Click(object sender, EventArgs e)
        {
            if (dgvAttendanceHistory.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FileName = $"Attendance_History_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveDialog.FileName))
                    {
                        // Write header
                        file.WriteLine("Student ID,Student Name,Date,Status");

                        // Write data
                        foreach (DataGridViewRow row in dgvAttendanceHistory.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string line = $"{row.Cells[0].Value},{row.Cells[1].Value}," +
                                        $"{row.Cells[2].Value},{row.Cells[3].Value}";
                            file.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Attendance history exported successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting file: {ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSearchStudentNameID_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStudent.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Show all rows
                foreach (DataGridViewRow row in dgvAttendanceHistory.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                // Filter rows
                foreach (DataGridViewRow row in dgvAttendanceHistory.Rows)
                {
                    if (row.IsNewRow) continue;

                    string studentID = row.Cells["HistoryStudentID"].Value?.ToString().ToLower() ?? "";
                    string studentName = row.Cells["HistoryStudentName"].Value?.ToString().ToLower() ?? "";

                    row.Visible = studentID.Contains(searchText) || studentName.Contains(searchText);
                }
            }
        }

        private void btnGenerateStats_Click(object sender, EventArgs e)
        {
            if (cboStatsSubject.SelectedItem == null)
            {
                MessageBox.Show("Please select a subject.",
                    "No Subject Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadAttendanceStatistics();
        }
        private void LoadAttendanceStatistics()
        {
            // TODO: Load from database and calculate statistics
            dgvStatistics.Rows.Clear();

            // Sample statistics data
            dgvStatistics.Rows.Add("2024001", "John Doe", 28, 2, 1, 0, "93.3%");
            dgvStatistics.Rows.Add("2024002", "Jane Smith", 25, 4, 1, 1, "83.3%");
            dgvStatistics.Rows.Add("2024003", "Mike Johnson", 30, 0, 1, 0, "100%");
            dgvStatistics.Rows.Add("2024004", "Sarah Brown", 27, 3, 0, 1, "90%");
            dgvStatistics.Rows.Add("2024005", "Tom Wilson", 26, 3, 2, 0, "86.7%");

            // Calculate overall statistics
            int totalStudents = dgvStatistics.Rows.Count;
            double avgAttendance = 0;

            foreach (DataGridViewRow row in dgvStatistics.Rows)
            {
                if (row.IsNewRow) continue;
                string rate = row.Cells["AttendanceRate"].Value.ToString().Replace("%", "");
                avgAttendance += double.Parse(rate);
            }

            avgAttendance = avgAttendance / totalStudents;

            lblStatsInfo.Text = $"Total Students: {totalStudents} | Average Attendance: {avgAttendance:F1}%";
        }

        private void btnExportStats_Click(object sender, EventArgs e)
        {
            if (dgvStatistics.Rows.Count == 0)
            {
                MessageBox.Show("No statistics to export.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                FileName = $"Attendance_Statistics_{DateTime.Now:yyyyMMdd}.csv"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveDialog.FileName))
                    {
                        // Write header
                        file.WriteLine("Student ID,Student Name,Present,Absent,Late,Excused,Attendance Rate");

                        // Write data
                        foreach (DataGridViewRow row in dgvStatistics.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string line = $"{row.Cells[0].Value},{row.Cells[1].Value}," +
                                        $"{row.Cells[2].Value},{row.Cells[3].Value}," +
                                        $"{row.Cells[4].Value},{row.Cells[5].Value},{row.Cells[6].Value}";
                            file.WriteLine(line);
                        }
                    }

                    MessageBox.Show("Statistics exported successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting file: {ex.Message}",
                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
