using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface Iterator
    {
        bool hasNext();
        Music next();
        Music first();
    }
}
