using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public class DistanceStudent2 : Student
    {
        public DistanceStudent2()
        {
            AttendanceType = new OnLine();
            LabType = new UseCloud();
        }

        public override int StudentID()
        {
            return 14;
        }

        public override string StudentName()
        {
            return "Jone";
        }
    }
}