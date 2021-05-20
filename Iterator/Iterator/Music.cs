using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Music
    {
        public string musicName;
        public int lenghtInSecond;

        public Music(string musicName, int lenghtInSecond)
        {
            this.musicName = musicName;
            this.lenghtInSecond = lenghtInSecond;
        }

        public string InMinutsAndSecond()
        {
            string minuts = (lenghtInSecond / 60).ToString();
            string seconds;
            string time;
            if (lenghtInSecond % 60 < 10)
                seconds = "0" + (lenghtInSecond % 60).ToString();
            else if(lenghtInSecond % 60 == 0)
                seconds = "00";
            else
                seconds = (lenghtInSecond % 60).ToString();

            time = minuts + ":" + seconds;

            return time;
        }
    }
}
