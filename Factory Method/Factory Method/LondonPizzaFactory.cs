using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class LondonPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
                return new CheesePizza(type + " London Style");
            else if (type == "veggie")
                return new VeggiePizza(type + " London Style");
            else if (type == "pepperoni")
                return new PepperoniPizza(type + " London Style");
            else
                return null;
        }
    }
}
