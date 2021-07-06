using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class StaffKioskWrap : IKiosk
    {
        private StaffParkingKiosk _staffParkingKiosk;

        public StaffKioskWrap(decimal _hours)
        {
            //throw new System.NotImplementedException();
            _staffParkingKiosk = new StaffParkingKiosk();
            _staffParkingKiosk.StaffHoursParked = _hours;
        }

        public decimal HoursParked
        {
            get
            {
                return _staffParkingKiosk.StaffHoursParked;
            }
        }

        public decimal FindParkingAmount()
        {
            //throw new System.NotImplementedException();
            return _staffParkingKiosk.FindStaffParkingAmount();
        }
    }
}