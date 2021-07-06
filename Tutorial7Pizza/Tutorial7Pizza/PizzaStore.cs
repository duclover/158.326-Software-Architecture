using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            //throw new System.NotImplementedException();
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            //throw new System.NotImplementedException();
            Pizza myPizza = _factory.CreatePizza(type);
            myPizza.Prepare();
            myPizza.Bake();
            myPizza.Bake();
            return myPizza;
        }
    }
}