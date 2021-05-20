using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Pizza
    {
        public string pizzaName;

        public Pizza(String pizzaName)
        {
            this.pizzaName = pizzaName;
        }

        public void Prepare() 
        {
            Console.WriteLine("Przygotujemy pizzy...");
        }
        public void Bake()
        {
            Console.WriteLine("Wypiekamy pizze...");
        }
        public void Cut()
        {
            Console.WriteLine("Krojimy pizze...");
        }
        public void Box()
        {
            Console.WriteLine("Pakujemy pizze... \n");
        }
    }
}
