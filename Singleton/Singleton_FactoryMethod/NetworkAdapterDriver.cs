using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class NetworkAdapterDriver
    {
        private static NetworkAdapterDriver uniqueNetDriver;
        private String networkAdapterDriverName = "Standart NetWork Adapter Driver";

        private NetworkAdapterDriver() { }

        public static NetworkAdapterDriver DownoloadNetworkAdapterDriver()
        {
            if(uniqueNetDriver == null)
            {
                uniqueNetDriver = new NetworkAdapterDriver();
            }
            return uniqueNetDriver;
        }

        public void ChangeDriver(String driverName)
        {
            networkAdapterDriverName = driverName;
        }

        public void RestoreDriver()
        {
            networkAdapterDriverName = "Standart NetWork Adapter Driver";
        }
    }
}
