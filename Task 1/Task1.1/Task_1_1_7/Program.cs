using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];

            ArrayForming(array);
            Console.Write("Исходные массив: ");
            PrintArray(array);

            Console.Write("Максимум: ");
            Console.WriteLine(Max(array));

            Console.Write("Минимум: ");
            Console.WriteLine(Min(array));

            Sorting(array);
            Console.Write("Отсортированный массив: ");
            PrintArray(array);

            Console.ReadKey();
        }

        static void ArrayForming(int[] array)       //метод заполняющий массив
        {
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(150);
            }
        }

        static void Sorting(int[] arr)          //сортировка
        {
            int temp = arr.Length / 2;
            while (temp > 0)
            {
                int i, j;
                for (i = temp; i < arr.Length; i++)
                {
                    int value = arr[i];
                    for (j = i - temp; (j >= 0) && (arr[j] > value); j -= temp)
                        arr[j + temp] = arr[j];
                    arr[j + temp] = value;
                }
                temp /= 2;
            }
        }

        static int Max(int[] array)           //нахождение максимума 
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                    max = array[i];
            }
            return max;
        }

        static int Min(int[] array)            //нахождение минимума 
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            return min;
        }

        static void PrintArray(int[] arr)       //вывод массива в консоль 
        {
            StringBuilder builder = new StringBuilder();
            
            for (int i = 0; i < arr.Length - 1; i++)
                builder.Append(arr[i] + ", ");
            builder.Append(arr[arr.Length - 1]);

            Console.WriteLine(builder);
        }
    }
}
