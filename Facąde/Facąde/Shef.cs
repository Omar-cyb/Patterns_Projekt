using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class Shef
    {
        public void MakeOrder(String order)
        {
            Console.WriteLine("Shef got the order: {0}", order);
            Console.WriteLine("Shef is cooking...");
            Console.WriteLine("Shef was cooked {0}", order);
        }
    }
}
