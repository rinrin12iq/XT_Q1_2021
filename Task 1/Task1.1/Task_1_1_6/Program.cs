using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] FontType = new bool[3] { false, false, false };
            while (true)
            {
                Text(FontType);
                FontPick(Console.ReadLine(), FontType);
            }
        }

        static void FontPick(string insert, bool[] FontType)
        {
            switch (insert)
            {
                case "1":
                    if (FontType[0] == true)
                        FontType[0] = false;
                    else
                        FontType[0] = true;
                    break;

                case "2":
                    if (FontType[1] == true)
                        FontType[1] = false;
                    else
                        FontType[1] = true;
                    break;

                case "3":
                    if (FontType[2] == true)
                        FontType[2] = false;
                    else
                        FontType[2] = true;
                    break;

                case "f":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ошибка. Введите один из перечисленных вариантов или нажмите f для выхода");
                    break;
            }
        }

        static void Text(bool[] FontType)
        {
            string font = null;

            if (FontType[0] == false && FontType[1] == false && FontType[2] == false)
                font = "None";

            else
            {
                for (int i = 0; i < FontType.Length; i++)
                {
                    if (FontType[i])
                        font += Enum.GetName(typeof(Font), i) + ", ";
                }
            }

            Console.WriteLine("Параметры надписи: " + font + "\nВведите: \n" +
                "\t 1: Bold \n\t 2: Italic \n\t 3: Underline \n");
        }

        enum Font
        {
            Bold = 0,
            Italic = 1,
            Underline = 2,
        }
    }
}
