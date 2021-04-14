using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int numberOfPeople = InputHelper();

            Console.WriteLine("Введите, какой по счету человек будет вычеркнут каждый раунд:");
            int numberToDelete = InputHelper();

            List<int> mass = ListForming(numberOfPeople);

            int currentIndex = 0, roundNumber = 1;

            while (mass.Count > numberToDelete - 1)
            {
                if(currentIndex + numberToDelete - 1 >= mass.Count)
                {
                    currentIndex -= mass.Count;
                }

                mass.RemoveAt(currentIndex + numberToDelete - 1);

                currentIndex += numberToDelete - 1;

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < mass.Count; i++)
                {
                    builder.Append(mass[i]+ "; ");
                }

                Console.WriteLine($"Раунд {roundNumber}. Вычеркнут человек. Людей осталось: {mass.Count}");
                Console.WriteLine(builder);

                roundNumber++;
            }

            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }

        static List<int> ListForming(int n)
        {
            List<int> mass = new List<int>();
            int number = 0;
            
            for (int i = 0; i < n; i++)
            {
                mass.Add(++number);
            }
            
            return mass;
        }

        private static int InputHelper()
        {
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("N должно быть целым числом больше нуля, повторите ввод:");
            }
            
            return n;
        }
    }
}
