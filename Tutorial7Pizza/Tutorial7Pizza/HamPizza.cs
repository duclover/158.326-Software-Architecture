using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public class HamPizza : Pizza
    {
        public override string Bake()
        {
            return "I am baking a HAM Pizza";
        }

        public override string Box()
        {
            return "I am boxing a HAM Pizza";
        }

        public override string Prepare()
        {
            return "I am preparing a HAM Pizza";
        }
    }
}