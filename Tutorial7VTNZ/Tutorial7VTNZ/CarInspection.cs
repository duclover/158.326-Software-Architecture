using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7VTNZ
{
    public class CarInspection
    {
        private decimal _price;
        private string _service;

        public CarInspection()
        {
            //throw new System.NotImplementedException();
        }

        public CarInspection(string InspectionName, decimal Price)
        {
            //throw new System.NotImplementedException();
            _service = InspectionName;
            _price = Price;
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
        }

        public string Service
        {
            get
            {
                return _service;
            }
        }

        public string ShowCarInspectionDetail()
        {
            //throw new System.NotImplementedException();
            return _service + "\nPrice $" + _price;
        }
    }
}