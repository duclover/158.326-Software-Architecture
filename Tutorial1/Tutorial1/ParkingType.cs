using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class ParkingType //父类
    {
        private const int _MAXHOUR = 24;
        public const double  _RATE = 2;
        public double Hours //封装
        {
            get;
        }

        public ParkingType(double hours)
        {
            if (hours > _MAXHOUR)
            {
                ParkingException ex = new ParkingException();
                throw ex;
            }
            Hours = Math.Ceiling(hours);
        }

        public virtual double ParkingAmount()
        {
            //throw new NotImplementedException();
            return Hours * _RATE;
            //return Hours;
        }
    }
}
