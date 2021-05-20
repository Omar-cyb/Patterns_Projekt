using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class GraphicDriver
    {
        private static GraphicDriver uniqueGraphicDriver;
        private String graphicDriverName = "Standard Graphic Driver";

        private GraphicDriver() { }

        public static GraphicDriver DownoloadGraphicDriver()
        {
            if (uniqueGraphicDriver == null)
            {
                uniqueGraphicDriver = new GraphicDriver();
            }
            return uniqueGraphicDriver;
        }

        public void ChangeDriver(String driverName)
        {
            graphicDriverName = driverName;
        }

        public void RestoreDriver()
        {
            graphicDriverName = "Standard Graphic Driver";
        }
    }
}
