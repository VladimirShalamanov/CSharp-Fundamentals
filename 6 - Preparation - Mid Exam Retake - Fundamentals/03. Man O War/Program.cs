using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> warShip = Console.ReadLine()
                .Split('>', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxHealth = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = arr[0];

                if (type == "Fire")
                {
                    int index = int.Parse(arr[1]);
                    int damage = int.Parse(arr[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (type == "Defend")
                {
                    int startIndex = int.Parse(arr[1]);
                    int endIndex = int.Parse(arr[2]);
                    int damege = int.Parse(arr[3]);
                    bool isTarget = false;

                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        isTarget = true;
                    }
                    if (isTarget)
                    {
                        while (startIndex != endIndex + 1)
                        {
                            pirateShip[startIndex] -= damege;
                            if (pirateShip[startIndex] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                            startIndex++;
                        }
                    }
                }
                else if (type == "Repair")
                {
                    int index = int.Parse(arr[1]);
                    int health = int.Parse(arr[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (type == "Status")
                {
                    int num = pirateShip.FindAll(x => x < maxHealth * 0.2).Count;
                    Console.WriteLine($"{num} sections need repair.");
                }
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
