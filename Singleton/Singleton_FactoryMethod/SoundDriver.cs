using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SoundDriver
    {
        private static SoundDriver uniqueSoundDriver;
        private String soundDriverName = "Standard Sound Driver";

        private SoundDriver() {  }

        public static SoundDriver DownoloadSoundDriver()
        {
            if (uniqueSoundDriver == null)
            {
                uniqueSoundDriver = new SoundDriver();
            }
            return uniqueSoundDriver;
        }

        public void ChangeDriver(String driverName)
        {
            soundDriverName = driverName;
        }

        public void RestoreDriver()
        {
            soundDriverName = "Standard Sound Driver";
        }
    }
}
