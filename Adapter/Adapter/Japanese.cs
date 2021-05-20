using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Japanese
    {
        public string name;

        public Japanese(string name) { this.name = name; }

        public void speakInJapanese()
        {
            Console.WriteLine(name + " says Hello");
        }
    }
}
