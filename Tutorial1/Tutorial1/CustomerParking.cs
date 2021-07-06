using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class CustomerParking : ParkingType
    {
        public CustomerParking(double cusHours) : base(cusHours) { }//使用base调用父类的方法

        //public override double ParkingAmount()
        //{
        //    return Hours * _RATE;
        //}
    }
}
