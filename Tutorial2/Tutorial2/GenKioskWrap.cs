using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public class GenKioskWrap : IKiosk
    {
        private GeneralParkingKiosk _generalParkingKiosk;           

        public GenKioskWrap(decimal _hours)
        {
            //throw new System.NotImplementedException();
            _generalParkingKiosk = new GeneralParkingKiosk();
            _generalParkingKiosk.GeneralHoursParked = _hours;
        }

        public decimal HoursParked
        {
            get
            {
                return _generalParkingKiosk.GeneralHoursParked;
            }
           
        }

        public decimal FindParkingAmount()
        {
            //throw new System.NotImplementedException();
            return _generalParkingKiosk.FindGeneralParkingAmount();
        }
    }
}