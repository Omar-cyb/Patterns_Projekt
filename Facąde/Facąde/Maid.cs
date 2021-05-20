using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class Maid
    {
        public void cleanRoom(Room room)
        {
            if (room.clean == false)
            {
                room.clean = true;
                Console.WriteLine("Room number {0} was cleaned", room.number);
            }
            else
                Console.WriteLine("Room number {0} is already cleaned", room.number);
        }
    }
}
