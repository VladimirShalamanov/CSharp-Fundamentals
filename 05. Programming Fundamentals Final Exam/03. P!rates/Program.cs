using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> settlements = new Dictionary<string, int[]>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Sail")
            {
                string[] arr = cmd
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string city = arr[0];
                int population = int.Parse(arr[1]);
                int gold = int.Parse(arr[2]);

                if (settlements.ContainsKey(city))
                {
                    settlements[city][0] += population;
                    settlements[city][1] += gold;
                    continue;
                }
                settlements.Add(city, new int[] { population, gold });
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                string town = arr[1];

                if (type == "Plunder")
                {
                    int people = int.Parse(arr[2]);
                    int gold = int.Parse(arr[3]);

                    settlements[town][0] -= people;
                    settlements[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (settlements[town][0] == 0 || settlements[town][1] == 0)
                    {
                        settlements.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                        continue;
                    }
                }
                else if (type == "Prosper")
                {
                    int gold = int.Parse(arr[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }

                    settlements[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {settlements[town][1]} gold.");
                }
            }

            if (settlements.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {settlements.Count} wealthy settlements to go to:");
                foreach (var item in settlements)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
