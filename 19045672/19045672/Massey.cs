using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19045672
{
    public sealed class Massey : University
    {
        private static Massey _massey;

        private Massey(string Name)
        {
            this.z_name = Name;
        }

        public static Massey GetInstance(string Name)
        {
            if (_massey == null)
            {
                _massey = new Massey(Name);
            }
            return _massey;
        }

        public override string PriPrintDetail()
        {
            //throw new NotImplementedException();
            return z_name;
        }
    }
}