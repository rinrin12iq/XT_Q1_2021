using System;
using System.Text;

namespace Task_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string text1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");
            string text2 = Console.ReadLine();

            Console.Write("Результирующая строка: ");
            Console.WriteLine(Doubler(text1, text2));
        }

        static string Doubler(string text1, string text2)
        {
            StringBuilder builder = new StringBuilder();
            
            bool IfNotMatches;
            for (int i = 0; i < text1.Length; i++)
            {
                IfNotMatches = true;
                for (int j = 0; j < text2.Length; j++)
                {
                    if (text1[i] == text2[j])
                    {
                        builder.Append(text1[i].ToString() + text1[i].ToString());
                        IfNotMatches = false;
                        break;
                    }
                }
                if (IfNotMatches)
                    builder.Append(text1[i]);
            }
            return builder.ToString();
        }
    }
}
