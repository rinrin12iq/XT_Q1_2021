using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[25];

            ArrayForming(array);
            Console.WriteLine("Элементы массива:");
            PrintArray(array);

            Console.Write("Сумма неотрицальных элементов: ");
            Console.WriteLine(SumOfNonNegative(array));

            Console.ReadKey();
        }

        static void ArrayForming(int[] array)
        {
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-150, 150);
            }
        }

        static void PrintArray(int[] arr)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < arr.Length - 1; i++)
                builder.Append(arr[i] + ", ");
            builder.Append(arr[arr.Length - 1]);

            Console.WriteLine(builder);
        }

        static int SumOfNonNegative(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    sum += array[i];
            }
            return sum;
        }
    }
}
