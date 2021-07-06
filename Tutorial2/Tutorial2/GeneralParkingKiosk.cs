using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class GeneralParkingKiosk
    {
        private decimal _HoursParked;
        private const decimal RATE = 2;

        public decimal GeneralHoursParked
        {
            get;
            set;
        }

        public decimal FindGeneralParkingAmount()
        {
            //throw new System.NotImplementedException();
            return RATE * Math.Ceiling(GeneralHoursParked);
        }
    }
}