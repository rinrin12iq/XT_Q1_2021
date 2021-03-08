using System;
using System.Collections.Generic;

namespace Task_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', ',', '.', ';', ':' };

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            List<string> words = new List<string>(text.Split(delimiterChars));
            words.RemoveAll(i => i == "");

            Console.Write("Количество слов, начинающихся с маленькой буквы: ");
            Console.WriteLine(LowerCase(words));
        }

        static int LowerCase(IEnumerable<string> words)
        {
            int n = 0;

            foreach (string word in words)
            {
                if (char.IsLower(word[0]))
                    n++;
            }
            
            return n;
        }
    }
}
