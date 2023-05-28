using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Word
    {
        private List<string> words = new List<string>();
        private List<string> hiddenWords = new List<string>();
        private Random random = new Random();

        public List<string> SplitWords(string scripture)
        {
            words = new List<string>(scripture.Split(' '));
            return words;
        }

        public List<string> HideWords(int count = 1)
        {
            hiddenWords = new List<string>(words);

            while (count > 0)
            {
                int index = random.Next(hiddenWords.Count);

                // Check if the word is already hidden
                if (!hiddenWords[index].Contains('_'))
                {
                    hiddenWords[index] = new string('_', hiddenWords[index].Length);
                    count--;
                }
            }

            return hiddenWords;
        }

        public string Display()
        {
            string adjustedWords = string.Join(" ", hiddenWords);
            return adjustedWords;
        }

        public bool AllWordsHidden()
        {
            foreach (string word in hiddenWords)
            {
                if (!word.Contains('_'))
                    return false;
            }
            return true;
        }
    }
}
