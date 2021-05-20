using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MusicPlayerIterator : Iterator
    {
        public List<Music> musicPlayer;
        int musicPosition = 0;

        public MusicPlayerIterator()
        {
            musicPlayer = new List<Music>();
        }

        public void AddMusic(Music music)
        {
            musicPlayer.Add(music);
            Console.WriteLine(" '{0}' was added to player", music.musicName);
        }

        public Music first()
        {
            return musicPlayer[0];
        }

        public bool hasNext()
        {
            if (musicPosition < musicPlayer.Count || musicPosition == null)
                return true;
            else
                return false;
        }

        public Music next()
        {
            Music music = musicPlayer[musicPosition];
            musicPosition++;

            return music;
        }
    }
}
