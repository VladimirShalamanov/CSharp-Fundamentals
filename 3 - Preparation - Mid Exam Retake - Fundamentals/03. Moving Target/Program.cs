using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                int index = int.Parse(arr[1]);
                int power = int.Parse(arr[2]);

                if (type == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (type == "Add")
                {
                    if (index >= 0 && index < arr.Length)
                    {
                        targets.Insert(index, power);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (type == "Strike")
                {
                    int leftRadius = index - power;
                    int rightRadius = index + power;
                    int range = power * 2 + 1;

                    if (leftRadius >= 0 && rightRadius <= targets.Count)
                    {
                        targets.RemoveRange(leftRadius, range);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
