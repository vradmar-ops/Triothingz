using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using ADOX;

namespace Students_Attendance
{
    public class DatabaseHelper
    {
        // Database file path - will be created in application folder
        private static string dbPath = Path.Combine(Application.StartupPath, "AttendanceDB.accdb");
        private static string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

        // Alternative for older Access versions (.mdb):
        // private static string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";

        // Initialize database - creates database and tables if they don't exist
        public static bool InitializeDatabase()
        {
            try
            {
                if (!File.Exists(dbPath))
                {
                    return CreateDatabase();
                }

                // Check if tables exist
                if (!TablesExist())
                {
                    CreateTables();
                    InsertSampleData();
                    MessageBox.Show("Database tables created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static bool TablesExist()
        {
            try
            {
                // Try to query Users table
                string query = "SELECT COUNT(*) FROM Users";
                object result = ExecuteScalar(query);

                if (result != null)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        private static bool CreateDatabase()
        {
            try
            {
                // Create the Access database file
                var catalog = new ADOX.Catalog();
                catalog.Create(connectionString);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(catalog);

                // Create tables
                CreateTables();
                InsertSampleData();

                MessageBox.Show("Database created successfully!\n\nDefault Login:\nAdmin: admin / admin123\nTeacher: teacher1 / teacher123",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating database: {ex.Message}\n\nMake sure Microsoft Access Database Engine is installed.\n\nDownload from:\nhttps://www.microsoft.com/en-us/download/details.aspx?id=54920",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private static void CreateTables()
        {
            try
            {
                // Create Users table
                ExecuteNonQuery(@"CREATE TABLE Users (
        UserID AUTOINCREMENT PRIMARY KEY,
        Username TEXT(50),
        [Password] TEXT(50),
        FullName TEXT(100),
        Role TEXT(20),
        Status TEXT(20),
        CreatedDate DATETIME,
        LastLogin DATETIME
    )
");
                ExecuteNonQuery(@"CREATE TABLE Students (
    StudentID TEXT(20) PRIMARY KEY,
    StudentName TEXT(100),
    DateEnrolled DATETIME,
    [Status] TEXT(20),
    CreatedDate DATETIME
)");

                // Create Students table
                ExecuteNonQuery(@"CREATE TABLE Subjects (
    SubjectID COUNTER PRIMARY KEY,
    SubjectCode TEXT(20),
    SubjectName TEXT(100),
    CreatedDate DATETIME
)");

                // Create Subjects table
                ExecuteNonQuery(@"CREATE TABLE TeacherSubjects (
    AssignmentID COUNTER PRIMARY KEY,
    TeacherID INTEGER,
    SubjectID INTEGER,
    AssignedDate DATETIME
)");

                // Create TeacherSubjects table
                ExecuteNonQuery(@"CREATE TABLE StudentSubjects (
    EnrollmentID COUNTER PRIMARY KEY,
    StudentID TEXT(20),
    SubjectID INTEGER,
    TeacherID INTEGER,
    EnrolledDate DATETIME
)");

                // Create StudentSubjects table
                ExecuteNonQuery(@"CREATE TABLE StudentSubjects (
                    EnrollmentID AUTOINCREMENT PRIMARY KEY,
                    StudentID TEXT(20),
                    SubjectID INTEGER,
                    TeacherID INTEGER,
                    EnrolledDate DATETIME
                )");

                // Create Attendance table
                ExecuteNonQuery(@"CREATE TABLE Attendance (
    AttendanceID COUNTER PRIMARY KEY,
    StudentID TEXT(20),
    SubjectID INTEGER,
    AttendanceDate DATETIME,
    [Status] TEXT(20),
    MarkedBy INTEGER,
    MarkedDateTime DATETIME,
    Remarks TEXT(255)
)
");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating tables: {ex.Message}",
                    "Table Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private static void InsertSampleData()
        {
            try
            {
                // Insert default admin
                ExecuteNonQuery(@"INSERT INTO Users (Username, Password, FullName, Role, Status, CreatedDate) 
                    VALUES ('admin', 'admin123', 'System Administrator', 'Admin', 'Active', Now())");

                // Insert sample teachers
                ExecuteNonQuery(@"INSERT INTO Users (Username, Password, FullName, Role, Status, CreatedDate) 
                    VALUES ('teacher1', 'teacher123', 'Prof. Sarah Williams', 'Teacher', 'Active', Now())");
                ExecuteNonQuery(@"INSERT INTO Users (Username, Password, FullName, Role, Status, CreatedDate) 
                    VALUES ('teacher2', 'teacher123', 'Prof. Mark Davis', 'Teacher', 'Active', Now())");

                // Insert sample students
                ExecuteNonQuery(@"INSERT INTO Students (StudentID, StudentName, DateEnrolled, Status, CreatedDate) 
                    VALUES ('2024001', 'John Doe', Now(), 'Active', Now())");
                ExecuteNonQuery(@"INSERT INTO Students (StudentID, StudentName, DateEnrolled, Status, CreatedDate) 
                    VALUES ('2024002', 'Jane Smith', Now(), 'Active', Now())");
                ExecuteNonQuery(@"INSERT INTO Students (StudentID, StudentName, DateEnrolled, Status, CreatedDate) 
                    VALUES ('2024003', 'Mike Johnson', Now(), 'Active', Now())");
                ExecuteNonQuery(@"INSERT INTO Students (StudentID, StudentName, DateEnrolled, Status, CreatedDate) 
                    VALUES ('2024004', 'Sarah Brown', Now(), 'Active', Now())");
                ExecuteNonQuery(@"INSERT INTO Students (StudentID, StudentName, DateEnrolled, Status, CreatedDate) 
                    VALUES ('2024005', 'Tom Wilson', Now(), 'Active', Now())");

                // Insert sample subjects
                ExecuteNonQuery(@"INSERT INTO Subjects (SubjectCode, SubjectName, CreatedDate) 
                    VALUES ('CS101', 'Introduction to Programming', Now())");
                ExecuteNonQuery(@"INSERT INTO Subjects (SubjectCode, SubjectName, CreatedDate) 
                    VALUES ('MATH101', 'Calculus I', Now())");
                ExecuteNonQuery(@"INSERT INTO Subjects (SubjectCode, SubjectName, CreatedDate) 
                    VALUES ('ENG101', 'English Composition', Now())");

                // Assign subjects to teachers (TeacherID 2 = teacher1, TeacherID 3 = teacher2)
                ExecuteNonQuery("INSERT INTO TeacherSubjects (TeacherID, SubjectID, AssignedDate) VALUES (2, 1, Now())");
                ExecuteNonQuery("INSERT INTO TeacherSubjects (TeacherID, SubjectID, AssignedDate) VALUES (2, 2, Now())");
                ExecuteNonQuery("INSERT INTO TeacherSubjects (TeacherID, SubjectID, AssignedDate) VALUES (3, 3, Now())");

                // Enroll students in subjects
                ExecuteNonQuery("INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID, EnrolledDate) VALUES ('2024001', 1, 2, Now())");
                ExecuteNonQuery("INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID, EnrolledDate) VALUES ('2024001', 2, 2, Now())");
                ExecuteNonQuery("INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID, EnrolledDate) VALUES ('2024002', 1, 2, Now())");
                ExecuteNonQuery("INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID, EnrolledDate) VALUES ('2024002', 3, 3, Now())");
                ExecuteNonQuery("INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID, EnrolledDate) VALUES ('2024003', 1, 2, Now())");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting sample data: {ex.Message}",
                    "Data Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        // Execute SELECT queries and return DataTable
        public static DataTable ExecuteQuery(string query, OleDbParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"ExecuteQuery error: {ex.Message}", ex);
            }
            return dt;
        }

        // Execute INSERT, UPDATE, DELETE queries
        public static int ExecuteNonQuery(string query, OleDbParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing command: {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }

        // Execute scalar query (returns single value)
        public static object ExecuteScalar(string query, OleDbParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Don't show message box here - let caller handle it
                throw new Exception($"ExecuteScalar error: {ex.Message}", ex);
            }
            return result;
        }

        // ==================== AUTHENTICATION ====================

        public static bool AuthenticateUser(string username, string password, string role)
        {
            try
            {
                string query = @"SELECT UserID, FullName FROM Users 
                               WHERE Username = ? 
                               AND Password = ? 
                               AND Role = ? 
                               AND Status = 'Active'";

                OleDbParameter[] parameters = {
                    new OleDbParameter("p1", username),
                    new OleDbParameter("p2", password),
                    new OleDbParameter("p3", role)
                };

                DataTable dt = ExecuteQuery(query, parameters);

                if (dt.Rows.Count > 0)
                {
                    UserSession.UserId = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    UserSession.Username = username;
                    UserSession.Role = role;
                    UserSession.FullName = dt.Rows[0]["FullName"].ToString();

                    // Update last login
                    string updateQuery = "UPDATE Users SET LastLogin = Now() WHERE UserID = ?";
                    ExecuteNonQuery(updateQuery, new OleDbParameter[] {
                        new OleDbParameter("p1", UserSession.UserId)
                    });

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Authentication error: {ex.Message}",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // ==================== STUDENT OPERATIONS ====================

        public static DataTable GetAllStudents()
        {
            string query = "SELECT StudentID, StudentName, DateEnrolled, Status FROM Students ORDER BY StudentName";
            return ExecuteQuery(query);
        }

        public static bool AddStudent(string studentID, string studentName)
        {
            string query = "INSERT INTO Students (StudentID, StudentName) VALUES (?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("@StudentID", studentID),
                new OleDbParameter("@StudentName", studentName)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool UpdateStudent(string studentID, string studentName)
        {
            string query = "UPDATE Students SET StudentName = ? WHERE StudentID = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("@StudentName", studentName),
                new OleDbParameter("@StudentID", studentID)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool DeleteStudent(string studentID)
        {
            string query = "DELETE FROM Students WHERE StudentID = ?";
            OleDbParameter[] parameters = { new OleDbParameter("@StudentID", studentID) };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        // ==================== TEACHER OPERATIONS ====================

        public static DataTable GetAllTeachers()
        {
            string query = "SELECT UserID, Username, FullName, Status FROM Users WHERE Role = 'Teacher' ORDER BY FullName";
            return ExecuteQuery(query);
        }

        public static bool AddTeacher(string username, string password, string fullName)
        {
            string query = "INSERT INTO Users (Username, Password, FullName, Role) VALUES (?, ?, ?, 'Teacher')";
            OleDbParameter[] parameters = {
                new OleDbParameter("@Username", username),
                new OleDbParameter("@Password", password),
                new OleDbParameter("@FullName", fullName)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool DeleteTeacher(int userID)
        {
            string query = "DELETE FROM Users WHERE UserID = ? AND Role = 'Teacher'";
            OleDbParameter[] parameters = { new OleDbParameter("@UserID", userID) };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        // ==================== SUBJECT OPERATIONS ====================

        public static DataTable GetAllSubjects()
        {
            string query = "SELECT SubjectID, SubjectCode, SubjectName FROM Subjects ORDER BY SubjectCode";
            return ExecuteQuery(query);
        }

        public static bool AddSubject(string subjectCode, string subjectName)
        {
            string query = "INSERT INTO Subjects (SubjectCode, SubjectName) VALUES (?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("@SubjectCode", subjectCode),
                new OleDbParameter("@SubjectName", subjectName)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool DeleteSubject(int subjectID)
        {
            string query = "DELETE FROM Subjects WHERE SubjectID = ?";
            OleDbParameter[] parameters = { new OleDbParameter("@SubjectID", subjectID) };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        // ==================== ASSIGNMENT OPERATIONS ====================

        public static DataTable GetAllAssignments()
        {
            string query = @"SELECT 
                                s.StudentName, 
                                sub.SubjectCode & ' - ' & sub.SubjectName as SubjectName,
                                u.FullName as TeacherName,
                                ss.EnrollmentID,
                                s.StudentID,
                                sub.SubjectID,
                                u.UserID as TeacherID
                            FROM (StudentSubjects ss
                            INNER JOIN Students s ON ss.StudentID = s.StudentID)
                            INNER JOIN Subjects sub ON ss.SubjectID = sub.SubjectID
                            INNER JOIN Users u ON ss.TeacherID = u.UserID
                            ORDER BY s.StudentName, sub.SubjectCode";
            return ExecuteQuery(query);
        }

        public static bool AssignStudentToSubject(string studentID, int subjectID, int teacherID)
        {
            string query = "INSERT INTO StudentSubjects (StudentID, SubjectID, TeacherID) VALUES (?, ?, ?)";
            OleDbParameter[] parameters = {
                new OleDbParameter("@StudentID", studentID),
                new OleDbParameter("@SubjectID", subjectID),
                new OleDbParameter("@TeacherID", teacherID)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static bool RemoveAssignment(int enrollmentID)
        {
            string query = "DELETE FROM StudentSubjects WHERE EnrollmentID = ?";
            OleDbParameter[] parameters = { new OleDbParameter("@EnrollmentID", enrollmentID) };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static DataTable GetTeacherSubjects(int teacherID)
        {
            string query = @"SELECT sub.SubjectID, sub.SubjectCode & ' - ' & sub.SubjectName as SubjectName
                           FROM Subjects sub
                           INNER JOIN TeacherSubjects ts ON sub.SubjectID = ts.SubjectID
                           WHERE ts.TeacherID = ?
                           ORDER BY sub.SubjectCode";
            OleDbParameter[] parameters = { new OleDbParameter("@TeacherID", teacherID) };
            return ExecuteQuery(query, parameters);
        }

        // ==================== ATTENDANCE OPERATIONS ====================

        public static DataTable GetStudentsBySubject(int subjectID, int teacherID)
        {
            string query = @"SELECT s.StudentID, s.StudentName
                           FROM Students s
                           INNER JOIN StudentSubjects ss ON s.StudentID = ss.StudentID
                           WHERE ss.SubjectID = ? AND ss.TeacherID = ?
                           ORDER BY s.StudentName";
            OleDbParameter[] parameters = {
                new OleDbParameter("@SubjectID", subjectID),
                new OleDbParameter("@TeacherID", teacherID)
            };
            return ExecuteQuery(query, parameters);
        }

        public static DataTable GetAttendanceForDate(int subjectID, DateTime date)
        {
            string query = @"SELECT StudentID, Status 
                           FROM Attendance 
                           WHERE SubjectID = ? 
                           AND AttendanceDate = ?";
            OleDbParameter[] parameters = {
                new OleDbParameter("@SubjectID", subjectID),
                new OleDbParameter("@Date", date.Date)
            };
            return ExecuteQuery(query, parameters);
        }

        public static bool SaveAttendance(string studentID, int subjectID, DateTime date, string status, int markedBy)
        {
            // Check if attendance already exists
            string checkQuery = @"SELECT COUNT(*) FROM Attendance 
                                WHERE StudentID = ? 
                                AND SubjectID = ? 
                                AND AttendanceDate = ?";
            OleDbParameter[] checkParams = {
                new OleDbParameter("@StudentID", studentID),
                new OleDbParameter("@SubjectID", subjectID),
                new OleDbParameter("@Date", date.Date)
            };

            int count = Convert.ToInt32(ExecuteScalar(checkQuery, checkParams));

            string query;
            OleDbParameter[] parameters;

            if (count > 0)
            {
                // Update existing
                query = @"UPDATE Attendance 
                         SET Status = ?, MarkedBy = ?, MarkedDateTime = Now() 
                         WHERE StudentID = ? AND SubjectID = ? AND AttendanceDate = ?";
                parameters = new OleDbParameter[] {
                    new OleDbParameter("@Status", status),
                    new OleDbParameter("@MarkedBy", markedBy),
                    new OleDbParameter("@StudentID", studentID),
                    new OleDbParameter("@SubjectID", subjectID),
                    new OleDbParameter("@Date", date.Date)
                };
            }
            else
            {
                // Insert new
                query = @"INSERT INTO Attendance (StudentID, SubjectID, AttendanceDate, Status, MarkedBy) 
                         VALUES (?, ?, ?, ?, ?)";
                parameters = new OleDbParameter[] {
                    new OleDbParameter("@StudentID", studentID),
                    new OleDbParameter("@SubjectID", subjectID),
                    new OleDbParameter("@Date", date.Date),
                    new OleDbParameter("@Status", status),
                    new OleDbParameter("@MarkedBy", markedBy)
                };
            }

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public static DataTable GetAttendanceHistory(int subjectID, DateTime fromDate, DateTime toDate)
        {
            string query = @"SELECT 
                                s.StudentID,
                                s.StudentName,
                                a.AttendanceDate,
                                a.Status
                            FROM Attendance a
                            INNER JOIN Students s ON a.StudentID = s.StudentID
                            WHERE a.SubjectID = ?
                            AND a.AttendanceDate BETWEEN ? AND ?
                            ORDER BY a.AttendanceDate DESC, s.StudentName";

            OleDbParameter[] parameters = {
                new OleDbParameter("@SubjectID", subjectID),
                new OleDbParameter("@FromDate", fromDate.Date),
                new OleDbParameter("@ToDate", toDate.Date)
            };

            return ExecuteQuery(query, parameters);
        }

        public static DataTable GetAttendanceStatistics(int subjectID, DateTime fromDate, DateTime toDate)
        {
            string query = @"SELECT 
                                s.StudentID,
                                s.StudentName,
                                SUM(IIF(a.Status = 'Present', 1, 0)) as Present,
                                SUM(IIF(a.Status = 'Absent', 1, 0)) as Absent,
                                SUM(IIF(a.Status = 'Late', 1, 0)) as Late,
                                SUM(IIF(a.Status = 'Excused', 1, 0)) as Excused,
                                FORMAT((SUM(IIF(a.Status = 'Present', 1, 0)) * 100.0 / COUNT(*)), '0.00') as AttendanceRate
                            FROM Students s
                            INNER JOIN StudentSubjects ss ON s.StudentID = ss.StudentID
                            LEFT JOIN Attendance a ON s.StudentID = a.StudentID AND a.SubjectID = ss.SubjectID
                                AND a.AttendanceDate BETWEEN ? AND ?
                            WHERE ss.SubjectID = ?
                            GROUP BY s.StudentID, s.StudentName
                            ORDER BY s.StudentName";

            OleDbParameter[] parameters = {
                new OleDbParameter("@FromDate", fromDate.Date),
                new OleDbParameter("@ToDate", toDate.Date),
                new OleDbParameter("@SubjectID", subjectID)
            };

            return ExecuteQuery(query, parameters);
        }
    }

    // User Session Class
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            FullName = null;
            Role = null;
        }
    }
}