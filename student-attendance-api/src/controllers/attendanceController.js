const db = require('../models/db');

exports.addAttendance = async (req, res) => {
  try {
    const { student_id, date, time_in, time_out, status } = req.body;
    const [result] = await db.query(
      'INSERT INTO Attendance (student_id, date, time_in, time_out, status) VALUES (?, ?, ?, ?, ?)',
      [student_id, date, time_in, time_out, status || 'PRESENT']
    );
    res.status(201).json({ 
      message: 'Attendance added successfully', 
      attendanceId: result.insertId 
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

exports.getAllAttendance = async (req, res) => {
  try {
    const { date, status } = req.query;
    let query = 'SELECT a.*, s.name as student_name, s.grade, s.section FROM Attendance a JOIN Students s ON a.student_id = s.id WHERE 1=1';
    let params = [];
    
    if (date) {
      query += ' AND a.date = ?';
      params.push(date);
    }
    if (status) {
      query += ' AND a.status = ?';
      params.push(status);
    }
    
    const [attendance] = await db.query(query, params);
    res.json(attendance);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

exports.getAttendanceById = async (req, res) => {
  try {
    const [attendance] = await db.query(
      'SELECT a.*, s.name as student_name, s.grade, s.section FROM Attendance a JOIN Students s ON a.student_id = s.id WHERE a.id = ?',
      [req.params.id]
    );
    if (attendance.length === 0) {
      return res.status(404).json({ message: 'Attendance record not found' });
    }
    res.json(attendance[0]);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

exports.updateAttendance = async (req, res) => {
  try {
    const { time_in, time_out, status } = req.body;
    const [result] = await db.query(
      'UPDATE Attendance SET time_in = ?, time_out = ?, status = ? WHERE id = ?',
      [time_in, time_out, status, req.params.id]
    );
    if (result.affectedRows === 0) {
      return res.status(404).json({ message: 'Attendance record not found' });
    }
    res.json({ message: 'Attendance updated successfully' });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

exports.removeAttendance = async (req, res) => {
  try {
    const [result] = await db.query(
      'DELETE FROM Attendance WHERE id = ?',
      [req.params.id]
    );
    if (result.affectedRows === 0) {
      return res.status(404).json({ message: 'Attendance record not found' });
    }
    res.json({ message: 'Attendance removed successfully' });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};