const db = require('../models/db');

// Get Attendance by Date
exports.getAttendanceByDate = async (req, res) => {
  try {
    const [attendance] = await db.query(
      `SELECT a.*, s.name as student_name, s.grade, s.section 
       FROM Attendance a 
       JOIN Students s ON a.student_id = s.id 
       WHERE a.date = ?`,
      [req.params.date]
    );
    res.json(attendance);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Get Attendance by Student
exports.getAttendanceByStudent = async (req, res) => {
  try {
    const [attendance] = await db.query(
      `SELECT a.*, s.name as student_name, s.grade, s.section 
       FROM Attendance a 
       JOIN Students s ON a.student_id = s.id 
       WHERE a.student_id = ?
       ORDER BY a.date DESC`,
      [req.params.studentId]
    );
    res.json(attendance);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Get Attendance by Status
exports.getAttendanceByStatus = async (req, res) => {
  try {
    const [attendance] = await db.query(
      `SELECT a.*, s.name as student_name, s.grade, s.section 
       FROM Attendance a 
       JOIN Students s ON a.student_id = s.id 
       WHERE a.status = ?`,
      [req.params.status]
    );
    res.json(attendance);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};