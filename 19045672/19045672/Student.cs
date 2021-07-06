using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public abstract class Student
    {
        private IAttendanceType _attendanceType;
        private ILabType _labType;

        public IAttendanceType AttendanceType
        {           
            set
            {
                _attendanceType = value;
            }
        }

        public ILabType LabType
        {
            set
            {
                _labType = value;
            }
        }

        public abstract int StudentID();

        public abstract string StudentName();

        public string Attendance()
        {
            return _attendanceType.AttendanceType();
        }

        public string Lab()
        {
            return _labType.LabType();
        }
    }
}