using System;

namespace Facąde
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            Shef shef = new Shef();
            Maid maid = new Maid();
            RestaurantSybsystem rsybsystem = new RestaurantSybsystem(waiter, shef);
            СonciergeSubsystem сonciergeSubsystem = new СonciergeSubsystem(maid, rsybsystem);

            Room room = new Room(1);
            Client client_1 = new Client("Jhon", "Smith");
            Client client_2 = new Client("Sarah","Adams");

            сonciergeSubsystem.ReserveRoom(room,client_1);
            сonciergeSubsystem.ReserveRoom(room, client_2);
            сonciergeSubsystem.GetOrder("Breakfast: eggs and beacon", room);
            сonciergeSubsystem.FreeRoom(room);

            Console.ReadKey();
        }
    }
}
