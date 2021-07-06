using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            //throw new System.NotImplementedException();
            FlyBehaviour = new FlyNoWay();
            QuackBehaviour = new MuteQuack();
        }

        public override string Display()
        {
            //throw new System.NotImplementedException();
            return "I am a decoy duck.";
        }
    }
}