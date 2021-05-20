using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public abstract class PizzaStore
    {
        PizzaFactory pizzaFactory;
        public PizzaStore(PizzaFactory factory)
        {
            pizzaFactory = factory;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza;
            pizza = pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
