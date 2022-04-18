using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
               .Split('@', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int countJumps = 0;
            string command;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = arr[0];
                int num = int.Parse(arr[1]);

                countJumps += num;
                if (countJumps >= neighborhood.Count)
                {
                    countJumps = 0;
                }
                if (type == "Jump")
                {
                    if (neighborhood[countJumps] == 0)
                    {
                        Console.WriteLine($"Place {countJumps} already had Valentine's day.");
                    }
                    else if (neighborhood[countJumps] > 0)
                    {
                        neighborhood[countJumps] -= 2;
                        if (neighborhood[countJumps] == 0)
                        {
                            Console.WriteLine($"Place {countJumps} has Valentine's day.");
                        }
                    }
                }
            }

            Console.WriteLine($"Cupid's last position was {countJumps}.");
            if (neighborhood.All(x => x == 0) == true)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                neighborhood.RemoveAll(x => x == 0);
                Console.WriteLine($"Cupid has failed {neighborhood.Count} places.");
            }
        }
    }
}
