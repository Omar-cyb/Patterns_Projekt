using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class RecipeTemplate
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }


        void boilWater() 
        {
            Console.WriteLine("Boiling water...");
        }
        void pourInCup()
        {
            Console.WriteLine("Pouring in cup...");
        }
        public abstract void brew();
        public abstract void addCondiments();
    }
}
