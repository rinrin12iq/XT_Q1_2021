using System;

namespace Task1._1._2
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
            
            DrawTriangle(n);

            Console.ReadKey();
        }

        static void DrawTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string s = new string('*', i);
                Console.WriteLine(s);
            }
        }
    }
}
