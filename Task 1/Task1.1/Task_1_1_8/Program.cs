using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[3, 4, 5];

            ArrayForming(array);
            Console.WriteLine("Элементы массива до замены:");
            ArrayPrint(array);

            NoPositive(array);
            Console.WriteLine("Элементы массива после замены:");
            ArrayPrint(array);

            Console.ReadKey();
        }

        static void ArrayForming(int[,,] array)         //метод заполняющий массив
        {
            Random r = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = r.Next(-150, 150);
                    }
                }
            }
        }
        static void ArrayPrint(int[,,] array)           //вывод массива в консоль
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2) - 1; k++)
                    {
                        builder.Append(array[i, j, k] + "  ");
                    }
                    builder.Append(array[i, j, array.GetLength(2) - 1] + Environment.NewLine);
                }
            }

            Console.WriteLine(builder);
        }

        static void NoPositive(int[,,] array)           //метод заменяющий положительные числа в массиве на 0
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i, j, k] > 0)
                            array[i, j, k] = 0;
                    }
                }
            }
        }
    }
}
