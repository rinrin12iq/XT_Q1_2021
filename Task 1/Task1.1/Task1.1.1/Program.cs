using System;

namespace Task1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите длину: ");
            while (!Int32.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.Write("Длина должна быть целым целым числом больше нуля, повторите ввод:");
            }
            
            Console.Write("Введите ширину: ");
            while (!Int32.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.Write("Ширина должна быть целым целым числом больше нуля, повторите ввод:");
            }

            Console.WriteLine("Площадь прямоугольника: " + a * b);

            Console.ReadKey();
        }
    }
}
