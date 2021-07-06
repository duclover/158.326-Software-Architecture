using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public abstract class Pizza
    {
        public abstract string Bake();

        public abstract string Box();

        public abstract string Prepare();
    }
}