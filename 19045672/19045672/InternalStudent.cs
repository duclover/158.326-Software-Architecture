using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public class InternalStudent : Student
    {
        public InternalStudent()
        {
            AttendanceType = new InClass();
            LabType = new UseLab();
        }

        public override int StudentID()
        {
            return 11;
        }

        public override string StudentName()
        {
            return "John";
        }
    }
}