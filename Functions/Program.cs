using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            //Task_7();
            Task_8();
        }

        static void Task_1()
        {
            Action<string> action = text =>
            {
                foreach (var s in text.Split(' ').ToArray())
                {
                    Console.WriteLine(s);
                }
            };
            action(Console.ReadLine());
        }

        static void Task_2()
        {
            Action<string> action = text =>
            {
                foreach (var s in text.Split(' ').ToArray())
                {
                    Console.WriteLine(s + " (нет в наличии)");
                }
            };
            action(Console.ReadLine());
        }

        static void Task_3()
        {
            string minPos = Console.ReadLine();
            Func<string, int> func = line =>
            {
                int[] numbers = line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                return numbers.Min();
            };
            Console.WriteLine(func(minPos));
        }

        static void Task_4()
        {
            Func<string, string, bool> func = (line, parity) =>
            {
                int[] range = line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                for (int i = range[0]; i <= range[1]; i++)
                {
                    if (parity.Equals("odd"))
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i + " ");
                        }
                    }
                    if (parity.Equals("even"))
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i + " ");
                        }
                    }
                }
                return true;
            };
            func(Console.ReadLine(), Console.ReadLine());
        }

        static void Task_5()
        {
            string line = Console.ReadLine();
            Func<string, bool> func = line =>
            {
                var array = new List<int>();
                foreach (var s in line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray())
                {
                    array.Add(s);
                }
                int[] number = array.ToArray();
                bool output = false;
                bool end = false;
                while (!end)
                {
                    string comand = Console.ReadLine();
                    switch (comand)
                    {
                        case "add":
                            for (int i = 0; i < number.Length; i++)
                            {
                                number[i]++;
                            }
                            break;
                        case "multiply":
                            for (int i = 0; i < number.Length; i++)
                            {
                                number[i] = number[i] * 2;
                            }
                            break;
                        case "subtract":
                            for (int i = 0; i < number.Length; i++)
                            {
                                number[i]--;
                            }
                            break;
                        case "print":
                            output = true;
                            break;
                        case "end":
                            end = true;
                            break;
                        default:
                            Console.WriteLine("Введена неверная команда");
                            break;
                    }

                }
                if (output)
                {
                    foreach (var s in number)
                    {
                        Console.Write(s + " ");
                    }
                }
                return true;
            };
            func(line);
        }

        static void Task_6()
        {
            string line = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            Func<string, int, List<int>> func = (line, num) =>
            {
                var array = new List<int>();
                foreach (var s in line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray())
                {
                    array.Add(s);
                }
                array.Reverse();
                foreach (var s in array.ToArray())
                {
                    if (s % num == 0)
                    {
                        array.Remove(s);
                    }
                }
                return array;
            };
            foreach (var s in func(line, num))
            {
                Console.Write(s + " ");
            }
        }

        static void Task_7()
        {
            int length = int.Parse(Console.ReadLine());
            string nameArray = Console.ReadLine();
            Func<int, string, List<string>> func = (length, line) =>
            {
                var array = new List<string>();
                foreach (var s in line.Split(' '))
                {
                    if (s.Length <= length)
                        array.Add(s);
                }
                return array;
            };
            foreach (var s in func(length, nameArray))
            {
                Console.Write(s + " ");
            }
        }

        static void Task_8()
        {
            string number = Console.ReadLine();
            Func<string, int[]> func = line =>
            {
                var array = new List<int>();
                foreach (var s in line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray())
                {
                    array.Add(s);
                }
                int[] number = array.ToArray();
                Array.Sort(number, new ListComparer());
                return number;
            };
            foreach (var s in func(number))
            {
                Console.Write(s + " ");
            }
        }

        class ListComparer : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (y % 2 == 0)
                    return 1;
                else if (x % 2 == 0)
                    return -1;
                else
                    return 0;
            }
        }
    }
}

