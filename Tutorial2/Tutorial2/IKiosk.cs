using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    public interface IKiosk
    {
        decimal HoursParked {
            get;
            //set;
        }

        decimal FindParkingAmount();
    }
}