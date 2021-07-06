using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7VTNZ
{
    public abstract class TestStation
    {
        protected string z_address;
        protected string z_name;
        protected string z_businessTime;

        public TestStation()
        {
            //throw new System.NotImplementedException();
        }

        public string Address
        {
            get
            {
                return z_address;
            }
            set
            {
                z_address = value;
            }
        }

        public string Name
        {
            get
            {
                return z_name;
            }
            set
            {
                z_name = value;
            }
        }

        public string BusinessTime
        {
            get
            {
                return z_businessTime;
            }
            set
            {
                z_businessTime = value;
            }
        }

        //抽象属性不能读写，即没有get、set
        public abstract string PrintDetail();
    }
}