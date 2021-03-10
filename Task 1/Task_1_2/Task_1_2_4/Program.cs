using System;
using System.Linq;
using System.Text;

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
            StringBuilder builder = new StringBuilder(text);
            int startIndex = 0;
            int firstLetterIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.' || text[i] == '!' || text[i] == '?')
                {
                    try
                    {
                        firstLetterIndex = startIndex + text.Substring(startIndex, i - startIndex + 1)
                        .IndexOf(text.Substring(startIndex, i - startIndex + 1)                 // находим индекс первой
                        .First(j => char.IsLetter(j)));                                         // буквы в предложении


                        builder[firstLetterIndex] = char.ToUpper(builder[firstLetterIndex]);    // заменяем букву на заглавную
                        startIndex = i + 1;
                    }
                    catch (InvalidOperationException)
                    {
                        continue;
                    }
                }
            }

            return builder.ToString();
        }
    }
}
