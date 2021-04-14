using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[] { 2, 3, 6, 8, 1, 4, 8, 23, 15, 33, 5, 2, 7, 15, 15, 11, 16, 16, 176, 15 };
            mass1.MostFrequent();
        }
    }

    public static class NumberArrayExtensions
    {
        public static void SomeFuntionInt32(this int[] array, Func<int, int> someFunc)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = someFunc(array[i]);
            }
        }

        public static int Sum(this int[] array)
        {
            int sum = 0;

            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        public static int Average(this int[] array)
        {
            return array.Sum()/array.Length;
        }

        public static void MostFrequent(this int[] array)
        {
            var a = array.GroupBy(i => i).OrderBy(i => i.Count());
            var b = a.FirstOrDefault().Key;
            Console.ReadKey();
        }
    }
}
