using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial6
{
    public class Quacker : IQuackBehaviour
    {
        //public Quacker()
        //{
        //    throw new System.NotImplementedException();
        //}

        public string Quack()
        {
            //throw new System.NotImplementedException();
            return "Quack quack";
        }
    }
}