using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class StaffParkingKiosk
    {
        public decimal _HoursParked;
        private const decimal RATE = 2;
        private const decimal SPECIALHOURS = 10;

        public decimal StaffHoursParked
        {
            get;
            set;
        }

        public decimal FindStaffParkingAmount()
        {
            //throw new System.NotImplementedException();
            if(StaffHoursParked <= SPECIALHOURS)
            {
                return RATE;
            }
            else
            {
                return RATE + RATE * (Math.Ceiling(StaffHoursParked) - SPECIALHOURS);
            }
        }
    }
}