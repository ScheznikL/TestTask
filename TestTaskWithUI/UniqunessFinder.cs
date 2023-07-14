using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTaskWithUI
{
    class UniqunessFinder
    {
        public static char GetFirstUnique(string userText)
        {
            return GetFirstUnique(TakeFirstLetter(userText));
        }

        private static char GetFirstUnique(IList<char> list)
        {
            Dictionary<char, int> indexes = new Dictionary<char, int>();

            foreach (var ch in list)
            {
                if (!indexes.ContainsKey(ch))
                    indexes.Add(ch, list.Count(x => ch == x));
            }
            return indexes.Where(x => x.Value == 1).First().Key;
        }

        private static List<char> TakeFirstLetter(string userText)
        {
            List<char> chArr = new List<char>();

            var tempWords = userText.Split(new char[] { ' ', '\n', '\"', '.', '\\', '\'' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in tempWords)
            {
                var lettersNum = word.Count(x => x == word[0]);
                if (lettersNum == 1 && char.IsLetterOrDigit(word[0]))
                {
                    chArr.Add(word[0]);
                }
            }
            return chArr;
        }
    }
}
