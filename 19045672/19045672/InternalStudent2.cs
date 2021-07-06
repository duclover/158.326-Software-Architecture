using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public class InternalStudent2 : Student
    {
        public InternalStudent2()
        {
            AttendanceType = new InClass();
            LabType = new UseLab();
        }

        public override int StudentID()
        {
            return 12;
        }

        public override string StudentName()
        {
            return "Mary";
        }
    }
}