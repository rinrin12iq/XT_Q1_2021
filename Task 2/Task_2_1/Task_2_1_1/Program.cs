using System;

namespace Task_2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Какая-то строка";
            MyString mystr1 = new MyString(str);
            MyString mystr2 = new MyString(str);
            Console.WriteLine(mystr1 + mystr2);
            Console.WriteLine(mystr1.Search('р'));
            Console.WriteLine(mystr1 == mystr2);
        }
    }
}
