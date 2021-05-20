using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class RestaurantSybsystem
    {
        Waiter waiter;
        Shef shef;

        public RestaurantSybsystem(Waiter waiter, Shef shef)
        {
            this.waiter = waiter;
            this.shef = shef;
        }

        public void GetOrder(String order,Room room)
        {
            waiter.GetOrder(order);
            shef.MakeOrder(order);
            waiter.BringAnOrder(order,room);
        }
    }
}
