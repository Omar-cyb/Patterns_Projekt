using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Computer
    {
        public OperationSystem OperationSystem;
        public void StartComputer(String OSname)
        {
            OperationSystem = OperationSystem.DownloadOS(OSname);
        }
    }
}
