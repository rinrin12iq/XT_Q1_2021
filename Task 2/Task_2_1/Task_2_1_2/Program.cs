using System;
using System.Collections.Generic;
using Task_2_1_2.Entities;

namespace Task_2_1_2
{
    class Program
    {
        private static int index = 0;

        static void Main(string[] args)
        {
            string currentSelection;
            List<User> users = new List<User>();

            List<string> startMenuItems = new List<string>() { "Выбрать пользователя", "Добавить пользователя", "Выход" };
            List<string> userMenuItems = new List<string>() { "Добавить фигуру", "Показать фигуры", "Удалить все фигуры"
                , "Назад" };
            List<string> figureTypes = new List<string>() { "Линия", "Треугольник", "Прямоугольник"
                , "Окружность", "Кольцо", "Круг", "Назад" };


            Console.CursorVisible = false;


            while (true)
            {
                switch (ShowMenu(startMenuItems))
                {
                    case "Выбрать пользователя":
                        {
                            if(users.Count == 0)
                            {
                                Console.WriteLine("Сначала добавьте хотя бы одного пользователя!");
                                Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить...");

                                Console.ReadKey();
                                Console.Clear();

                                goto case "Добавить пользователя";
                            }
                            
                            do
                            {
                                currentSelection = ShowMenu(users);
                            } while (currentSelection == string.Empty);

                            int currentUserIndex = index;
                            index = 0;
                            
                            bool selectedUserFlag = true;

                            while (selectedUserFlag)
                            {

                                do
                                {
                                    currentSelection = ShowMenu(userMenuItems);
                                } while (currentSelection == string.Empty);

                                index = 0;

                                switch (currentSelection)
                                {
                                    case "Добавить фигуру":
                                        {
                                            do
                                            {
                                                Console.WriteLine("Выберите фигуру:");
                                                currentSelection = ShowMenu(figureTypes);
                                            } while (currentSelection == string.Empty);

                                            Figure userFigure = CreateFigure(currentSelection);

                                            if (userFigure != null)
                                            {
                                                users[currentUserIndex].UserFigures.Add(userFigure);
                                            }
                                            else
                                            {
                                                index = 0;
                                                break;
                                            }


                                            index = 0;

                                            Console.WriteLine("Фигура успешно добавлена");
                                            Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить...");

                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        }
                                    case "Показать фигуры":
                                        {
                                            if (users[currentUserIndex].UserFigures.Count == 0)
                                            {
                                                Console.WriteLine("Сначала добавьте хотя бы одну фигуру!");
                                                Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить...");

                                                Console.ReadKey();
                                                Console.Clear();

                                                goto case "Добавить фигуру";
                                            }

                                            foreach (var figure in users[currentUserIndex].UserFigures)
                                            {
                                                Console.WriteLine(figure + Environment.NewLine);
                                            }

                                            Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить...");

                                            Console.ReadKey();
                                            Console.Clear();

                                            break;
                                        }
                                    case "Удалить все фигуры":
                                        {
                                            users[currentUserIndex].UserFigures.Clear();
                                            break;
                                        }
                                    case "Назад":
                                        {
                                            selectedUserFlag = false;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case "Добавить пользователя":
                        {
                            string userName;

                            Console.CursorVisible = true;
                            
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Введите имя пользователя:");
                                userName = Console.ReadLine();
                            } while (string.IsNullOrEmpty(userName));
                            

                            users.Add(new User(userName));

                            index = 0;
                            Console.CursorVisible = false;
                            
                            Console.WriteLine("Пользователь успешно добавлен");
                            Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить...");

                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                    case "Выход":
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }            
        }

        private static string ShowMenu(List<string> menuItems)
        {
            string temp = string.Empty;
            
            for (int i = 0; i < menuItems.Count; i++)
            {
                if(i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if(ckey.Key == ConsoleKey.DownArrow)
            {
                if(index == menuItems.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index == 0)
                {
                    index = menuItems.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                temp = menuItems[index];
            }

            Console.Clear();
            return temp;
        }

        private static string ShowMenu(List<User> menuItems)
        {
            string temp = string.Empty;

            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(menuItems[i].Name);
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();

            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (index == menuItems.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                if (index == 0)
                {
                    index = menuItems.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter)
            {
                temp = menuItems[index].Name;
            }

            Console.Clear();
            return temp;
        }

        private static Figure CreateFigure(string type)
        {
            switch (type)
            {
                case "Линия":
                    {
                        int x1, y1, x2, y2;

                        Console.WriteLine("Введите координату x первой точки линии:");
                        x1 = InputHelper(true);

                        Console.WriteLine("Введите координату y первой точки линии:");
                        y1 = InputHelper(true);

                        Console.WriteLine("Введите координату x второй точки линии:");
                        x2 = InputHelper(true);

                        Console.WriteLine("Введите координату y второй точки линии:");
                        y2 = InputHelper(true);

                        return new Line(x1, y1, x2, y2);
                    }
                case "Треугольник":
                    {
                        int sideA, sideB, sideC;

                        do
                        {
                            Console.WriteLine("Введите длину стороны A треугольника:");
                            sideA = InputHelper(false);

                            Console.WriteLine("Введите длину стороны B треугольника:");
                            sideB = InputHelper(false);

                            Console.WriteLine("Введите длину стороны C треугольника:");
                            sideC = InputHelper(false);

                            if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB)
                            {
                                Console.WriteLine("Сторона треугольника не может быть больше суммы двух других сторон");
                                Console.WriteLine("Повторите ввод");
                            }
                        } while (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB);

                        return new Triangle(sideA, sideB, sideC);
                    }
                case "Прямоугольник":
                    {
                        int side1, side2;

                        Console.WriteLine("Введите длину первой стороны прямоугольника:");
                        side1 = InputHelper(false);

                        Console.WriteLine("Введите длину первой стороны прямоугольника:");
                        side2 = InputHelper(false);

                        return new Rectangle(side1, side2);
                    }
                case "Окружность":
                    {
                        int x, y, radius;

                        Console.WriteLine("Введите координату x центра окружности:");
                        x = InputHelper(true);

                        Console.WriteLine("Введите координату y центра окружности:");
                        y = InputHelper(true);

                        Console.WriteLine("Введите длину радиуса окружности:");
                        radius = InputHelper(false);

                        return new Circle(x, y, radius);
                    }
                case "Кольцо":
                    {
                        int x, y, innerRadius, outerRadius;

                        Console.WriteLine("Введите координату x центра кольца:");
                        x = InputHelper(true);

                        Console.WriteLine("Введите координату y центра кольца:");
                        y = InputHelper(true);

                        Console.WriteLine("Введите длину внутреннего радиуса кольца:");
                        innerRadius = InputHelper(false);

                        do
                        {
                            Console.WriteLine("Введите длину внешнего радиуса кольца:");
                            outerRadius = InputHelper(false);

                            if (outerRadius < innerRadius)
                            {
                                Console.WriteLine("Внешний радиус должен быть больше внутреннего");
                                Console.WriteLine("Повторите ввод");
                            }
                        } while (outerRadius <= innerRadius);

                        return new Ring(x, y, innerRadius, outerRadius);
                    }
                case "Круг":
                    {
                        int x, y, radius;

                        Console.WriteLine("Введите координату x центра окружности:");
                        x = InputHelper(true);

                        Console.WriteLine("Введите координату y центра окружности:");
                        y = InputHelper(true);

                        Console.WriteLine("Введите длину радиуса окружности:");
                        radius = InputHelper(false);

                        return new Disk(x, y, radius);
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        private static int InputHelper(bool canBeZeroOrLess)
        {
            int n;

            if (canBeZeroOrLess)
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("N должно быть целым числом, повторите ввод:");
                }
            }
            else
            {
                while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.Write("N должно быть целым числом больше нуля, повторите ввод:");
                }
            }
            
            return n;
        }
    }
}
