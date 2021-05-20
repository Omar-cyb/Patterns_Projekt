using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class EnglishTranslator : IEnglishSpeakers
    {
        Japanese japaneseSpeaker;

        public EnglishTranslator(Japanese japaneseSpeaker) { this.japaneseSpeaker = japaneseSpeaker; }

        public void speakInEnglish()
        {
            Console.Write("Translator says that ");
            japaneseSpeaker.speakInJapanese();
        }
    }
}
