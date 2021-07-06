using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial7Pizza
{
    public class SimplePizzaFactory
    {
        private Pizza myPizza;

        public Pizza CreatePizza(string type)
        {
            //throw new System.NotImplementedException();
            if(type == "cheese")
            {
                myPizza = new CheesePizza();
            }
            else if(type == "ham")
            {
                myPizza = new HamPizza();
            }
            else
            {
                myPizza = new FunghiPizza();
            }
            return myPizza;
        }
    }
}