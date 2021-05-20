using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayerIterator musicIterator = new MusicPlayerIterator();

            Music music_1 = new Music("Stella", 245);
            Music music_2 = new Music("Telescop", 195);
            Music music_3 = new Music("Dive", 210);
            Music music_4 = new Music("Dead End in Tokyo", 223);

            musicIterator.AddMusic(music_1);
            musicIterator.AddMusic(music_2);
            musicIterator.AddMusic(music_3);
            musicIterator.AddMusic(music_4);

            Music tempMusic;
            
            tempMusic = musicIterator.next();

            while (musicIterator.hasNext())
            {
                tempMusic = musicIterator.next();
                Console.WriteLine("Next music is {0} {1}", tempMusic.musicName, tempMusic.InMinutsAndSecond());
            }

            tempMusic = musicIterator.first();
            Console.WriteLine("First music is {0} {1}", tempMusic.musicName, tempMusic.InMinutsAndSecond());

        }
    }
}
