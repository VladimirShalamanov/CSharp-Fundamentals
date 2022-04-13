using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise____Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arr = command
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (arr.Length == 2)
                {
                    int passangers = int.Parse(arr[1]);
                    wagons.Add(passangers);
                }
                else if (arr.Length == 1)
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int comingPass = int.Parse(arr[0]);
                        int currrWagon = wagons[i];
                        int leftPass = maxCapacity - currrWagon;
                        if (comingPass <= leftPass)
                        {
                            wagons[i] += comingPass;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
