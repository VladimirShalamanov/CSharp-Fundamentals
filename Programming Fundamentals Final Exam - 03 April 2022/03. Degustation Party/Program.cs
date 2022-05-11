using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Degustation_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> info = new Dictionary<string, List<string>>();

            int unliked = 0;
            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] arr = cmd
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                string guest = arr[1];
                string meal = arr[2];

                if (type == "Like")
                {
                    if (!info.ContainsKey(guest))
                    {
                        info.Add(guest, new List<string>() { meal });
                        continue;
                    }
                    else if (info[guest].Contains(meal))
                    {
                        continue;
                    }
                    info[guest].Add(meal);
                }
                else if (type == "Dislike")
                {
                    if (info.ContainsKey(guest) && info[guest].Contains(meal))
                    {
                        info[guest].Remove(meal);
                        unliked++;
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                    }
                    else if (!info.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!info[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                }
            }

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unliked}");
        }
    }
}
