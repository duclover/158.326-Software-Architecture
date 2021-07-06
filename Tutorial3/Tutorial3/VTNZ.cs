using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public class VTNZ : TestingStation
    {
        private IServiceType _service;
        private int _serviceNum = 0;
        private decimal _totalPrice = 0;

        public VTNZ()
        {
            //throw new System.NotImplementedException();
        }

        public VTNZ (string Name, string Address, string PhoneNum)
        {
            this.z_name = Name;
            this.z_address = Address;
            this.z_phoneNum = PhoneNum;
        }

        public IServiceType IServiceType
        {
            get
            {
                return _service;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        public int ServiceNums
        {
            get
            {
                return _serviceNum;
            }
        }

        public void RequestService(IServiceType service)
        {
            _service = service;
            _serviceNum += 1;
            _totalPrice += _service.Price;
        }

        public string ShowServiceDetail()
        {
            //throw new System.NotImplementedException();
            return "\nInspection Type " + _service.Type + "\nPrice" + _service.Price;
        }

        public override string printDetail()
        {
            return z_name + "\n" + z_address + "\n" + z_phoneNum;
        }
    }
}