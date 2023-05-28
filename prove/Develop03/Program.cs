using System;
using System.Collections.Generic;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Scripture scripture = new Scripture();
            Word word = new Word();
            Reference reference = new Reference();

            string randomScripture = scripture.SelectRandomScripture();
            (string scriptureReference, string scriptureText) = reference.GetReference(randomScripture);
            List<string> words = word.SplitWords(scriptureText);

            Console.WriteLine();

            int hiddenWordCount = 0;

            string input = "";
            while (input != "quit")
            {
                List<string> hiddenWords = word.HideWords(hiddenWordCount);
                string adjustedScripture = word.Display();

                Console.WriteLine(scriptureReference);
                Console.WriteLine();
                Console.WriteLine(adjustedScripture);
                Console.WriteLine();

                if (word.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden.");
                    break;
                }

                hiddenWordCount++;
                input = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
