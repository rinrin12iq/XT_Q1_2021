using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите текст:");
                string text = Console.ReadLine();

                Console.WriteLine("Статистика использования слов в тексте:");
                foreach (var word in text.FrequencyCount())
                {
                    Console.WriteLine(word.Key + " - " + word.Value);
                }

                Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    public static class StringExtensions
    {
        public static Dictionary<string, int> FrequencyCount(this string text)
        {
            Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            List<string> words = SplitedString(text);

            var temp = words.GroupBy(i => i);

            foreach (var item in temp)
            {
                countOfWords.Add(item.Key, item.Count());
            }

            return countOfWords;
        }

        private static List<string> SplitedString(string text)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', ';', '(', ')' };

            text = text.ToLower();
            List<string> words = new List<string>(text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries));

            return words;
        }
    }
}