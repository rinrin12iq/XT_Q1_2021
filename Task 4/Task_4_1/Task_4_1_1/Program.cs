using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_4_1_1
{
    class Program
    {
        private static string _path = @"D:\Files";
        private static int _index = 0;
        private static string _currentSelection = string.Empty;

        static void Main(string[] args)
        {
            MyLogger logger = new MyLogger(_path);

            while (true)
            {
                do
                {
                    Console.WriteLine("Select program mode:");
                    _currentSelection = ShowMenu("Observing mode", "Go to version mode", "Exit");
                } while (_currentSelection == string.Empty);

                _index = 0;

                switch (_currentSelection)
                {
                    case "Observing mode":
                        logger.Observe();
                        Console.Clear();
                        break;
                    case "Go to version mode":
                        string[] temp = logger.SelectVersionsByPath();

                        if (temp.Any())
                        {
                            do
                            {
                                _currentSelection = ShowMenu(temp);
                            } while (_currentSelection == string.Empty);

                            _index = 0;
                            string filePath = _currentSelection;

                            do
                            {
                                _currentSelection = ShowMenu(logger.SelectVersionsByDate(filePath));
                            } while (_currentSelection == string.Empty);

                            _index = 0;
                            logger.GoBackToVersion(filePath, _currentSelection);
                        }
                        else
                        {
                            Console.WriteLine("Log file is empty");
                            Console.WriteLine("Press enter to exit");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static string ShowMenu(params string[] menuItems)
        {
            string temp = string.Empty;

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == _index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (_index == menuItems.Length - 1)
                {
                    _index = 0;
                }
                else
                {
                    _index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (_index == 0)
                {
                    _index = menuItems.Length - 1;
                }
                else
                {
                    _index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                temp = menuItems[_index];
            }

            Console.Clear();
            return temp;
        }
    }
}
