using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int count = 0;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                count++;
                int[] arr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int index1 = arr[0];
                int index2 = arr[1];

                if (index1 >= 0 && index2 <= nums.Count)
                {
                    int middleElement = nums.Count / 2;
                    string elementAdd = $"-{count}a";
                    nums.Insert(middleElement, elementAdd);
                    nums.Insert(middleElement, elementAdd);
                }
                else if (nums[index1] == nums[index2])
                {
                    string guessElement = nums[index1];
                    nums.RemoveAll(x => x == guessElement);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessElement}!");
                }
                else if (nums[index1] != nums[index2])
                {
                    Console.WriteLine($"Try again!");
                }
                if (nums.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    break;
                }
            }

            if (nums.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", nums));
            }
        }
    }
}
