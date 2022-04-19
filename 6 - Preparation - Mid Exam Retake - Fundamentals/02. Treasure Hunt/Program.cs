using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] arr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                if (type == "Loot")
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        string item1 = arr[i];
                        bool isInside = false;
                        if (item1 != items.Find(x => x == item1))
                        {
                            isInside = true;
                        }
                        if (isInside)
                        {
                            items.Insert(0, item1);
                        }
                    }
                }
                else if (type == "Drop")
                {
                    int index = int.Parse(arr[1]);
                    if (index >= 0 && index <= items.Count)
                    {
                        string removeItem = items[index];
                        items.RemoveAt(index);
                        items.Add(removeItem);
                    }
                }
                else if (type == "Steal")
                {
                    int count = int.Parse(arr[1]);
                    if (count > items.Count)
                    {
                        count = items.Count;
                    }
                    List<string> stealItems = new List<string>();
                    for (int i = items.Count - count; i < items.Count; i++)
                    {
                        stealItems.Add(items[i]);
                    }
                    Console.WriteLine(string.Join(", ", stealItems));

                    string.Join(" ", stealItems);
                    for (int i = 0; i < stealItems.Count; i++)
                    {
                        items.Remove(stealItems[i]);
                    }
                }
            }

            if (items.Count > 0)
            {
                double sum = 0;
                string name;
                for (int i = 0; i < items.Count; i++)
                {
                    name = string.Join(" ", items[i]);
                    for (int j = 0; j < name.Length; j++)
                    {
                        sum++;
                    }
                }
                double average = sum / items.Count;
                Console.Write($"Average treasure gain: {average:f2} pirate credits.");
            }

            else if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
