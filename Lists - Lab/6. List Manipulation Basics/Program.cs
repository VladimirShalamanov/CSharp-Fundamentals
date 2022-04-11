using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string type = Console.ReadLine();

            while (type != "end")
            {
                string[] tokens = type.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numAdd = int.Parse(tokens[1]);
                        nums.Add(numAdd);
                        break;
                    case "Remove":
                        int numRemove = int.Parse(tokens[1]);
                        nums.Remove(numRemove);
                        break;
                    case "RemoveAt":
                        int indexRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexRemove);
                        break;
                    case "Insert":
                        int num = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        nums.Insert(index, num);
                        break;
                }

                type = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
