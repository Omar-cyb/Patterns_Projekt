using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class LondonPizzaStore : PizzaStore
    {
        public LondonPizzaStore(PizzaFactory factory) : base(factory)
        {
        }
    }
}
