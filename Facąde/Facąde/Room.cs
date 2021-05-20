using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facąde
{
    public class Room
    {
        public int number;
        public bool clean;
        public bool empty;
        public List<Client> clients;
        public bool breakfest;

        public Room(int number)
        {
            this.number = number;
            clients = new List<Client>();
            clean = true;
            empty = true;
            breakfest = false;
        }

        public void GetMess()
        {
            clean = false;
        }
        public void GetReserved()
        {
            empty = false;
        }
    }
}
