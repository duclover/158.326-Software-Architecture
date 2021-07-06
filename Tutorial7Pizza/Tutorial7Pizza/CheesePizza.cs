using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public class CheesePizza : Pizza
    {

        public override string Bake()
        {
            return "I am baking a CHEESE Pizza";
        }

        public override string Box()
        {
            return "I am boxing a CHEESE Pizza";
        }

        public override string Prepare()
        {
            return "I am preparing a CHEESE Pizza";
        }
    }
}