using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            tea.prepareRecipe();
            Console.WriteLine("////////");
            coffee.prepareRecipe();
        }
    }
}
