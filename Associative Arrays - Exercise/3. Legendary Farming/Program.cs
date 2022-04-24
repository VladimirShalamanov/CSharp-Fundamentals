using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, string> crafting = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne" },
                { "fragments", "Valanyr" },
                { "motes", "Dragonwrath" }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            string item = string.Empty;
            while (string.IsNullOrEmpty(item))
            {
                string[] materialsArr = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


                for (int i = 0; i < materialsArr.Length; i += 2)
                {
                    int quantity = int.Parse(materialsArr[i]);
                    string materialName = materialsArr[i + 1];

                    if (materials.ContainsKey(materialName))
                    {
                        materials[materialName] += quantity;
                        if (materials[materialName] >= 250)
                        {
                            item = crafting[materialName];
                            materials[materialName] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(materialName))
                        {
                            junk[materialName] = 0;
                        }

                        junk[materialName] += quantity;
                    }
                }
            }

            Console.WriteLine($"{item} obtained!");

            foreach (var itemA in materials)
            {
                Console.WriteLine($"{itemA.Key}: {itemA.Value}");
            }
            foreach (var itemJ in junk)
            {
                Console.WriteLine($"{itemJ.Key}: {itemJ.Value}");
            }
        }
    }
}
