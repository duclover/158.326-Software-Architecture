using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial9Rental
{    
    public class Rental
    {
        private decimal Discount_10 = 0.1M;
        private decimal Discount_15 = 0.15M;
        private decimal Discount_20 = 0.2M;

        public decimal TotalPrice(int day, RentalType rentalType)
        {
            decimal totalPrice = day * (decimal)rentalType;
            //1天到5天原价
            if (day >= 1 && day < 5)
            {
                return totalPrice;
            }
            //5天到10天，Discount_10
            else if (day >= 5 && day < 10)
            {
                return totalPrice = totalPrice * (1 - Discount_10);
            }
            //10天到20天，Discount_15
            else if (day >= 10 && day < 20)
            {
                return totalPrice = totalPrice * (1 - Discount_15);
            }
            //20天以上，Discount_20
            else if (day >= 20)
            {
                return totalPrice = totalPrice * (1 - Discount_20);
            }
            //小于1天，返回0
            else
            {
                return totalPrice = 0;
            }
        }
    }
}
