using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> personGoing = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string[] name = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (name.Length == 3)
                {
                    if (personGoing.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                    else if (!personGoing.Contains(name[0]))
                    {
                        personGoing.Add(name[0]);
                    }
                }
                else if (name.Length == 4)
                {
                    if (!personGoing.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }
                    else if (personGoing.Contains(name[0]))
                    {
                        personGoing.Remove(name[0]);
                    }
                }
            }

            for (int i = 0; i < personGoing.Count; i++)
            {
                Console.WriteLine(personGoing[i]);
            }
        }
    }
}
