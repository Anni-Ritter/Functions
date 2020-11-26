using System;
using System.Linq;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        static void Task1()
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

        static void Task2()
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

        static void Task3()
        {
            string minPos = Console.ReadLine();
            Func<string, int> func = line =>
            {
                int[] numbers = line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                return numbers.Min();
            };
            Console.WriteLine(func(minPos));
        }

        static void Task4()
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
    }
}

