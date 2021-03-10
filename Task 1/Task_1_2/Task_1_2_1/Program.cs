using System;
using System.Collections.Generic;

namespace Task_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', ',', '.', ';', ':', '\t' };

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            List<string> words = new List<string>(text.Split(delimiterChars));
            words.RemoveAll(i => i == "");

            Console.Write("Средняя длина слова: ");
            Console.WriteLine(AverageLength(words));

        }

        static double AverageLength(List<string> words)
        {
            double numberOfSymbols = 0;
            for (int i = 0; i < words.Count; i++)
                numberOfSymbols += words[i].Length;

            return numberOfSymbols / words.Count;
        }
    }
}
