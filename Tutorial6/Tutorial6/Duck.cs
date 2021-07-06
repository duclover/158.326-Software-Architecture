using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public abstract class Duck
    {
        private IFlyBehaviour _flyBehaviour;
        private IQuackBehaviour _quackBehaviour;

        public IQuackBehaviour QuackBehaviour
        {
            
            set
            {
                _quackBehaviour = value;
            }
        }

        public IFlyBehaviour FlyBehaviour
        {
            
            set
            {
                _flyBehaviour = value;
            }
        }

        public abstract string Display();

        public string PerformFly()
        {
            //throw new System.NotImplementedException();
            return _flyBehaviour.Fly();
        }

        public string PerformQuack()
        {
            //throw new System.NotImplementedException();
            return _quackBehaviour.Quack();
        }
    }
}