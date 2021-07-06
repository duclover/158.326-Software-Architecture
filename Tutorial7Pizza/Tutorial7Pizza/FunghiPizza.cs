using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public class FunghiPizza : Pizza
    {
        public override string Bake()
        {
            return "I am baking a FUNGHI Pizza";
        }

        public override string Box()
        {
            return "I am boxing a FUNGHI Pizza";
        }

        public override string Prepare()
        {
            return "I am preparing a FUNGHI Pizza";
        }
    }
}