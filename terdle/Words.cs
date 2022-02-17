using System;

namespace terdle
{
    public class Words
    {

        public static string RandomWord()
        {
            return GetWords()[RandomNum(0, GetWords().Length-1)];
        }

        public static string[] GetWords()
        {
            return Properties.Resources.words.Split("\n");
        }

        public static bool InDictionary(string word)
        {
            foreach (string w in GetWords())
            {
                if (w.Contains(word)) return true;
            }
            return false;
        }

        private static int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}