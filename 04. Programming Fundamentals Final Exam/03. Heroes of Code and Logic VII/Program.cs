using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroesData = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string hero = arr[0];
                int hp = int.Parse(arr[1]);
                int mp = int.Parse(arr[2]);
                heroesData[hero] = new List<int>() { hp, mp };
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] arr = cmd
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                string heroName = arr[1];

                if (type == "CastSpell")
                {
                    int mpNeeded = int.Parse(arr[2]);
                    string spellName = arr[3];

                    if (heroesData[heroName][1] >= mpNeeded)
                    {
                        heroesData[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesData[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (type == "TakeDamage")
                {
                    int damage = int.Parse(arr[2]);
                    string attacker = arr[3];

                    heroesData[heroName][0] -= damage;
                    if (heroesData[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesData[heroName][0]} HP left!");
                    }
                    else if (heroesData[heroName][0] <= 0)
                    {
                        heroesData.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (type == "Recharge")
                {
                    int amount = int.Parse(arr[2]);
                    if (heroesData[heroName][1] + amount >= 200)
                    {
                        int neededMp = 200 - heroesData[heroName][1];
                        heroesData[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {neededMp} MP!");
                    }
                    else if (heroesData[heroName][1] + amount < 200)
                    {
                        heroesData[heroName][1] += amount;
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (type == "Heal")
                {
                    int amount = int.Parse(arr[2]);
                    if (heroesData[heroName][0] + amount >= 100)
                    {
                        int neededHp = 100 - heroesData[heroName][0];
                        heroesData[heroName][0] = 100;
                        Console.WriteLine($"{heroName} healed for {neededHp} HP!");
                    }
                    else if (heroesData[heroName][0] + amount < 100)
                    {
                        heroesData[heroName][0] += amount;
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }

            foreach (var hero in heroesData)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
