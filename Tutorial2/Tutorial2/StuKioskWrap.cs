using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class StuKioskWrap : IKiosk
    {
        private StudentParkingKiosk _studentHoursParked;

        public StuKioskWrap(decimal _hours)
        {
            //throw new System.NotImplementedException();
            _studentHoursParked = new StudentParkingKiosk();
            _studentHoursParked.StudentHoursParked = _hours;

        }

        public decimal HoursParked
        {
            get
            {
                return _studentHoursParked.StudentHoursParked;
            }
        }

        public decimal FindParkingAmount()
        {
            //throw new System.NotImplementedException();
            return _studentHoursParked.FindStudentParkingAmount();
        }
    }
}