using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Coffee : RecipeTemplate
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}
