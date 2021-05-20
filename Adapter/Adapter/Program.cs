using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            American american = new American("Jhon");

            British british = new British("Ithan");

            Japanese japanese = new Japanese("Hayami");
            EnglishTranslator englishTranslator = new EnglishTranslator(japanese);

            american.speakInEnglish();
            british.speakInEnglish();
            englishTranslator.speakInEnglish();

            Console.ReadKey();
        }
    }
}
