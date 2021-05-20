using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class OperationSystem
    {
        private static OperationSystem uniqueOperationSystem;

        public NetworkAdapterDriver NetworkAdapterDriver;
        public GraphicDriver GraphicDriver;
        public SoundDriver SoundDriver;

        private String OSname;

        private OperationSystem(String OSname) { this.OSname = OSname; }

        public static OperationSystem DownloadOS(String OSname)
        {
            if (uniqueOperationSystem == null)
            {
                uniqueOperationSystem = new OperationSystem(OSname);
                uniqueOperationSystem.StartDrivers();
            }
            return uniqueOperationSystem;
        }

        public void StartDrivers()
        {
            NetworkAdapterDriver = NetworkAdapterDriver.DownoloadNetworkAdapterDriver();
            GraphicDriver = GraphicDriver.DownoloadGraphicDriver();
            SoundDriver = SoundDriver.DownoloadSoundDriver();
        }
        public void RestoreDrivers()
        {
            NetworkAdapterDriver.RestoreDriver();
            GraphicDriver.RestoreDriver();
            SoundDriver.RestoreDriver();
        }

        public void ChangeOS(String NewOSName)
        {
            OSname = NewOSName;
            RestoreDrivers();
        }
    }
}
