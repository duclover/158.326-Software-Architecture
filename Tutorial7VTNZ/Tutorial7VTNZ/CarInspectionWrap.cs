using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7VTNZ
{
    public class CarInspectionWrap : IServiceType
    {
        private CarInspection _carInspection;

        public CarInspectionWrap()
        {
            //throw new System.NotImplementedException();
        }

        public CarInspectionWrap(string InspectionName, decimal Price)
        {
            //throw new System.NotImplementedException();
            _carInspection = new CarInspection(InspectionName, Price);
        }

        public decimal Price
        {
            get
            {
                return _carInspection.Price;
            }
        }

        public string Type
        {
            get
            {
                return _carInspection.Service;
            }
        }

        public string ShowServiceDetail()
        {
            return _carInspection.ShowCarInspectionDetail();
        }
    }
}