using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> rarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> rating = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string plant = info[0];
                int currRarity = int.Parse(info[1]);

                if (!rarity.ContainsKey(plant))
                {
                    rarity[plant] = 0;
                }
                rarity[plant] = currRarity;
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Exhibition")
            {
                string[] info = cmd
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = info[0];
                string[] inf = info[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (type == "Rate")
                {
                    string plant = inf[0];
                    double currRating = double.Parse(inf[1]);

                    if (!rarity.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    if (!rating.ContainsKey(plant))
                    {
                        rating[plant] = new List<double>();
                    }

                    rating[plant].Add(currRating);
                }
                else if (type == "Update")
                {
                    string plant = inf[0];
                    int newRarity = int.Parse(inf[1]);

                    if (rarity.ContainsKey(plant))
                    {
                        rarity[plant] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (type == "Reset")
                {
                    string plant = inf[0];

                    if (!rarity.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    if (rating.ContainsKey(plant))
                    {
                        rating[plant].Clear();
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (KeyValuePair<string, int> item in rarity)
            {
                string plant = item.Key;
                int raritys = item.Value;
                double average = 0;

                if (rating.ContainsKey(plant) && rating[plant].Any())
                {
                    average = rating[plant].Average();
                }

                Console.WriteLine($"- {plant}; Rarity: {raritys}; Rating: {average:f2}");
            }
        }
    }
}
