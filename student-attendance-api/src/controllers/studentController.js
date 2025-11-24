const db = require('../models/db');

// Add Student
exports.addStudent = async (req, res) => {
  try {
    const { name, grade, section, status } = req.body;
    const [result] = await db.query(
      'INSERT INTO Students (name, grade, section, status) VALUES (?, ?, ?, ?)',
      [name, grade, section, status || 'ACTIVE']
    );
    res.status(201).json({ 
      message: 'Student added successfully', 
      studentId: result.insertId 
    });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Get All Students
exports.getAllStudents = async (req, res) => {
  try {
    const { status } = req.query;
    let query = 'SELECT * FROM Students';
    let params = [];
    
    if (status) {
      query += ' WHERE status = ?';
      params.push(status);
    }
    
    const [students] = await db.query(query, params);
    res.json(students);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Get Student by ID
exports.getStudentById = async (req, res) => {
  try {
    const [students] = await db.query(
      'SELECT * FROM Students WHERE id = ?',
      [req.params.id]
    );
    if (students.length === 0) {
      return res.status(404).json({ message: 'Student not found' });
    }
    res.json(students[0]);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Update Student
exports.updateStudent = async (req, res) => {
  try {
    const { name, grade, section, status } = req.body;
    const [result] = await db.query(
      'UPDATE Students SET name = ?, grade = ?, section = ?, status = ? WHERE id = ?',
      [name, grade, section, status, req.params.id]
    );
    if (result.affectedRows === 0) {
      return res.status(404).json({ message: 'Student not found' });
    }
    res.json({ message: 'Student updated successfully' });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};

// Remove Student (Soft Delete)
exports.removeStudent = async (req, res) => {
  try {
    const [result] = await db.query(
      'UPDATE Students SET status = "REMOVED" WHERE id = ?',
      [req.params.id]
    );
    if (result.affectedRows === 0) {
      return res.status(404).json({ message: 'Student not found' });
    }
    res.json({ message: 'Student removed successfully' });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
};