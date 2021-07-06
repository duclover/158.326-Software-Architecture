using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public class CarInspectionWrap : IServiceType
    {
        private CarInspection _carInspection;

        public CarInspectionWrap() { }

        public CarInspectionWrap(string InspectionName, decimal Price)
        {
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
            //throw new System.NotImplementedException();
            return _carInspection.ShowCarInspectionDetail();
        }
    }
}