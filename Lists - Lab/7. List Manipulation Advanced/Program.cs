using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._List_Manipulation_Advanced
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
            bool hasChanges = false;

            while (type != "end")
            {
                string[] tokens = type.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numAdd = int.Parse(tokens[1]);
                        nums.Add(numAdd);
                        hasChanges = true;
                        break;
                    case "Remove":
                        int numRemove = int.Parse(tokens[1]);
                        nums.Remove(numRemove);
                        hasChanges = true;
                        break;
                    case "RemoveAt":
                        int indexRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexRemove);
                        hasChanges = true;
                        break;
                    case "Insert":
                        int num = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        nums.Insert(index, num);
                        hasChanges = true;
                        break;
                    case "Contains":
                        int toCheck = int.Parse(tokens[1]);
                        if (nums.Contains(toCheck))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNums = nums.FindAll(x => x % 2 == 0);
                        Console.WriteLine(String.Join(" ", evenNums));
                        break;
                    case "PrintOdd":
                        List<int> oddNums = nums.FindAll(x => x % 2 != 0);
                        Console.WriteLine(String.Join(" ", oddNums));
                        break;
                    case "GetSum":
                        int sum = nums.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numCompare = int.Parse(tokens[2]);
                        if (condition == "<")
                        {
                            List<int> result = nums.FindAll(x => x < numCompare);
                            Console.WriteLine(string.Join(" ", result));
                        }
                        else if (condition == ">")
                        {
                            List<int> result = nums.FindAll(x => x > numCompare);
                            Console.WriteLine(string.Join(" ", result));
                        }
                        else if (condition == ">=")
                        {
                            List<int> result = nums.FindAll(x => x >= numCompare);
                            Console.WriteLine(string.Join(" ", result));
                        }
                        else if (condition == "<=")
                        {
                            List<int> result = nums.FindAll(x => x <= numCompare);
                            Console.WriteLine(string.Join(" ", result));
                        }
                        break;
                }

                type = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
