using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            //throw new System.NotImplementedException();
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Quacker();
        }

        public override string Display()
        {
            //throw new System.NotImplementedException();
            return "I am a red head duck.";
        }
    }
}