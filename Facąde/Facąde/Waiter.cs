using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class Waiter
    {
        public void GetOrder(String order)
        {
            Console.WriteLine("Waiter got an order: {0}", order);
        }
        public void BringAnOrder(String order,Room room)
        {
            room.breakfest = true;
            Console.WriteLine("Waiter brought an order: {0}", order);
        }
    }
}
