using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            Console.Write("Результат: ");
            Console.Write(Validator(text));

            Console.ReadKey();
        }

        public static string Validator(string text)
        {
            StringBuilder builder = new StringBuilder();
            int startIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    int firstLetterIndex = startIndex + text.Substring(startIndex, i - startIndex + 1)
                        .IndexOf(text.Substring(startIndex, i - startIndex + 1).First(j => char.IsLetter(j)));

                    builder.Append(text.Substring(startIndex, i - startIndex + 1));
                    builder[firstLetterIndex] = char.ToUpper(builder[firstLetterIndex]);
                    startIndex = i + 1;
                }
            }

            return builder.ToString();
        }
    }
}
