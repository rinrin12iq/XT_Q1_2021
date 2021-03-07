using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 5];

            ArrayForming(array);

            Console.WriteLine("Массив:");
            ArrayPrint(array);
            Console.Write("Сумма элементов, стоящих на чётных позициях: ");
            Console.WriteLine(SumOfEvenPosition(array));

            Console.ReadLine();
        }

        static void ArrayForming(int[,] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(150);
                }
            }
        }

        static void ArrayPrint(int[,] array)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    builder.Append(array[i, j] + "  ");
                }
                builder.Append(array[i, array.GetLength(1) - 1] + Environment.NewLine);
            }
            
            Console.Write(builder);
        }

        static int SumOfEvenPosition(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
            }
            return sum;
        }
    }
}
