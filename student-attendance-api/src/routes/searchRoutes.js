const express = require('express');
const router = express.Router();
const searchController = require('../controllers/searchController');

router.get('/attendance/:date', searchController.getAttendanceByDate);
router.get('/attendance/student/:studentId', searchController.getAttendanceByStudent);
router.get('/attendance/status/:status', searchController.getAttendanceByStatus);

module.exports = router;