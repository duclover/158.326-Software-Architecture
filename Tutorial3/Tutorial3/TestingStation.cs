using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3
{
    public abstract class TestingStation
    {
        protected string z_address;
        protected string z_name;
        protected string z_phoneNum;

        public TestingStation()
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

        public string PhoneNum
        {
            get
            {
                return z_phoneNum;
            }
            set
            {
                z_phoneNum = value;
            }
        }

        public abstract string printDetail();//抽象属性不能读写，即没有get、set

    }
}