using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public class DistanceStudent : Student
    {
        public DistanceStudent()
        {
            AttendanceType = new OnLine();
            LabType = new UseCloud();
        }

        public override int StudentID()
        {
            return 13;
        }

        public override string StudentName()
        {
            return "Tom";
        }
    }
}