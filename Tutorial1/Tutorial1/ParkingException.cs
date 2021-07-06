using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class ParkingException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Your car has been towed away";
            }
        }
    }
}
