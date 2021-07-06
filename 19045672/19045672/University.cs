using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public abstract class University
    {
        protected string z_name;

        public string Name
        {
            get { return z_name; }
            set { z_name = value; }
        }

        public abstract string PriPrintDetail();
    }
}