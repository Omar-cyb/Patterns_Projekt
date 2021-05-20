using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class СonciergeSubsystem
    {
        Maid maid;
        RestaurantSybsystem restaurantSybsystem;

        public СonciergeSubsystem(Maid maid, RestaurantSybsystem restaurantSybsystem)
        {
            this.maid = maid;
            this.restaurantSybsystem = restaurantSybsystem;
        }

        public void GetOrder(String order, Room room)
        {
            restaurantSybsystem.GetOrder(order, room);
        }

        public void FreeRoom(Room room)
        {
            room.clients = null;
            Console.WriteLine("Room number {0} was left", room.number);
            maid.cleanRoom(room);
        }
        public void CleanRoom(Room room)
        {
            maid.cleanRoom(room);
        }
        public void ReserveRoom(Room room, Client client)
        {
            room.empty = false;
            room.clients.Add(client);
            Console.WriteLine("Room number {0} was reserved by {1} {2}", room.number,client.firstName,client.lastName);
        }
    }
}
