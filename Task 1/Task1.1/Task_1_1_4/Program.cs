using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Введите N: ");
            while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("N должно быть целым целым числом больше нуля, повторите ввод:");
            }

            Console.WriteLine(DrawTriangle(n));

            Console.ReadKey();
        }

        static string DrawTriangle(int n)
        {
            StringBuilder builder = new StringBuilder();

            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i < k; i++)
                {
                    for (int j = 1; j <= n + i; j++)
                    {
                        if (j >= n - i && j < n + i)
                            builder.Append("*");

                        else if (j == n + i)
                        {
                            builder.Append("*" + Environment.NewLine);
                            continue;
                        }

                        else
                            builder.Append(" ");
                    }
                }
            }

            return builder.ToString();
        }
    }
    
}
