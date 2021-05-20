using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYorkPizzaFactory nyFactory = new NewYorkPizzaFactory();
            NYPizzaStore nyPizzaStore = new NYPizzaStore(nyFactory);

            LondonPizzaFactory londonPizzaFactory = new LondonPizzaFactory();
            LondonPizzaStore londonPizzaStore = new LondonPizzaStore(londonPizzaFactory);

            Pizza pizza_1 = nyPizzaStore.orderPizza("cheese");

            Pizza pizza_2 = londonPizzaStore.orderPizza("veggie");

            Console.WriteLine(pizza_1.pizzaName);
            Console.WriteLine(pizza_2.pizzaName);
        }
    }
}
