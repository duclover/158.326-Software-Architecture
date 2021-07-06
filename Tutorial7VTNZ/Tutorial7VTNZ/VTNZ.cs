using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7VTNZ
{
    public sealed class VTNZ : TestStation
    {
        private IServiceType _service;
        private static VTNZ _vtnz;
        private static int _serviceNum = 0;
        private static decimal _totalPrice = 0;

        private VTNZ()
        {
            //throw new System.NotImplementedException();
        }

        private VTNZ(string Name, string Address, string BusinessTime)
        {
            //throw new System.NotImplementedException();
            this.z_address = Address;
            this.z_name = Name;
            this.z_businessTime = BusinessTime;
        }

        public static VTNZ GetInstance(string Name, string Address, string BusinessTime)
        {
            //throw new System.NotImplementedException();
            if(_vtnz == null)
            {
                _vtnz = new VTNZ(Name, Address, BusinessTime);
            }
            return _vtnz;
        }

        private IServiceType IServiceType
        {
            get
            {
                return _service;
            }
        }

        public static int ServiceNums
        {
            get
            {
                return _serviceNum;
            }
        }

        public static decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }        

        public void RequestService(IServiceType service)
        {
            //throw new System.NotImplementedException();
            _service = service;
            _serviceNum += 1;
            _totalPrice += _service.Price;
        }

        public string ShowServiceDetail()
        {
            //throw new System.NotImplementedException();
            return "\nInspection Type " + _service.Type + "\nPrice" + _service.Price + "\n";
        }

        public override string PrintDetail()
        {
            //throw new System.NotImplementedException();
            return z_name + "\n" + z_address + "\n" + z_businessTime;
        }
    }
}