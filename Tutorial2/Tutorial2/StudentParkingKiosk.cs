using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class StudentParkingKiosk
    {
        public decimal _HoursParked;
        private const decimal RATE = 1;

        public decimal StudentHoursParked
        {
            get;
            set;
        }

        public decimal FindStudentParkingAmount()
        {
            //throw new System.NotImplementedException();
            return RATE * Math.Ceiling(StudentHoursParked);
        }
    }
}