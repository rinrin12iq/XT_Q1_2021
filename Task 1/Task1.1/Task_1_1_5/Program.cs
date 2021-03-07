using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum());
            Console.ReadKey();
        }

        static int Sum(int n = 1000)
        {
            int temp = 0;

            for (int i = 3; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    temp += i;
            }

            return temp;
        }
    }
}
