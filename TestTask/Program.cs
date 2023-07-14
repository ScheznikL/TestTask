/*Умова:
 * 
 *- програма приймає на вхід довільний текст і знаходить в кожному слові цього тексту найперший символ, 
 * який більше НЕ повторюється в аналізуємому слові
 *- далі із отриманого набору символів програма повинна вибрати перший унікальний (тобто той, який більше не зустручається в наборі) і повернути його.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    class Program
    {
        private static string _userText;
        private const string _testText = @"The Tao gave birth to machine language.  Machine language gave birth
                              to the assembler.
                              The assembler gave birth to the compiler.  Now there are ten thousand
                              languages.
                              Each language has its purpose, however humble.  Each language
                              expresses the Yin and Yang of software.  Each language has its place within
                              the Tao.
                              But do not program in COBOL if you can avoid it.
                                      -- Geoffrey James, \'The Tao of Programming\'";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text:");
            _userText = Console.ReadLine();
            Console.WriteLine("First the most unique letter:");
            Console.WriteLine(GetFirstUnique(TakeFirstLetter(_userText)));
            Console.ReadLine();
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

            var tempWords = userText.Split(new char[] { ' ', '\n', '\"', '.', '\\','\'' }, StringSplitOptions.RemoveEmptyEntries);

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
