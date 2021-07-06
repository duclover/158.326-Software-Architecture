using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class StaffParking:ParkingType
    {
        private const double  SPECIALHOURS = 10;
        public StaffParking(double staffHours) : base(staffHours) { }
        

        public override double ParkingAmount()
        {
            if (Hours  <= SPECIALHOURS)
            {
                return _RATE;
            }
            else
            {
                return _RATE + (Hours - SPECIALHOURS) * _RATE;
            }
           
        }
    }
}
