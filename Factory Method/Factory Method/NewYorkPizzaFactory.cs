using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class NewYorkPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
                return new CheesePizza(type + " New York Style");
            else if (type == "veggie")
                return new VeggiePizza(type + " New York Style");
            else if (type == "pepperoni")
                return new PepperoniPizza(type + " New York Style");
            else
                return null;
        }
    }
}
