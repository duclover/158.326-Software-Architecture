using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public class MuteQuack : IQuackBehaviour
    {
        //public MuteQuack()
        //{
        //    throw new System.NotImplementedException();
        //}

        public string Quack()
        {
            //throw new System.NotImplementedException();
            return "I can not quacks";
        }
    }
}