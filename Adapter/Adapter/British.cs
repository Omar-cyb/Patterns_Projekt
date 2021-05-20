using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class British : IEnglishSpeakers
    {
        public string name;

        public British(string name) { this.name = name; }

        public void speakInEnglish()
        {
            Console.WriteLine(name + " says Hello");
        }
    }
}
