using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terdle
{
    class Game
    {
        public static void ResetGame()
        {
            Console.Clear();

            Program.word = Words.RandomWord();
            Program.a_wordsGuessed = 0;
            Program.wordsGuessed = new List<string>();

            for(int i = 0; i != 6; i++)
            {
                Console.WriteLine("[][][][][]");
            }
        }

        public static void AddWords(string[] words)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            int index2 = 0;
            int correctChars = 0;

            foreach (string word in words)
            {
                Console.WriteLine("");
                int index1 = 0;

                foreach (char character in word)
                {
                    Console.Write("[");

                    if (Program.word.Contains(character))
                    {
                        if (Program.word.IndexOf(character) == word.IndexOf(character))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            correctChars++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                    }

                    Console.Write(character.ToString());

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("]");
                }

                index2++;
            }

            for(;  index2 != 6; index2++)
            {
                Console.Write("\n[][][][][]");
            }
        }
    }
}
