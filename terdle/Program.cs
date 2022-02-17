using System;
using System.Collections.Generic;

namespace terdle
{
    class Program
    {
        public static string word;
        public static int a_wordsGuessed;
        public static List<string> wordsGuessed = new List<string>();

        static void Main(string[] args)
        {
            while(true)
            {
                Game.ResetGame();

                while (a_wordsGuessed <= 6)
                {
                    Console.WriteLine("");
                    string guessedWord = Console.ReadLine();
                    if (guessedWord.Length != 5 || !Words.InDictionary(guessedWord)) continue;

                    wordsGuessed.Add(guessedWord);

                    Game.AddWords(wordsGuessed.ToArray());

                    a_wordsGuessed++;
                }
            }
        }
    }
}
