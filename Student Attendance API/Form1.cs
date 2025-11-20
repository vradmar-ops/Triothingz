namespace Students_Attendance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string role = cboRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || role == null)
            {
                MessageBox.Show("Please enter username, password, and select a role.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Authenticate user
            if (DatabaseHelper.AuthenticateUser(username, password, role))
            {
                MessageBox.Show($"Login successful!\nWelcome, {UserSession.FullName}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open appropriate dashboard
                if (role == "Admin")
                {
                    AdminDashboard adminForm = new AdminDashboard();
                    adminForm.Show();
                }
                else if (role == "Teacher")
                {
                    TeacherDashboard teacherForm = new TeacherDashboard();
                    teacherForm.Show();
                }

                this.Hide(); // Hide login form
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.InitializeDatabase();
        }
    }

}
