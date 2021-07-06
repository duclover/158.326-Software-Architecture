using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            //throw new System.NotImplementedException();
            FlyBehaviour = new FlyWithWings();
            QuackBehaviour = new Squeak();
        }

        public override string Display()
        {
            //throw new System.NotImplementedException();
            return "I am a Mallard duck";
        }
    }
}