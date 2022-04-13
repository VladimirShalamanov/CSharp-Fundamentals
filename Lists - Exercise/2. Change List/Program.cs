using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (arr.Length == 2)
                {
                    if (arr[0] == "Delete")
                    {
                        int numDelete = int.Parse(arr[1]);
                        nums.Remove(numDelete);
                    }
                }
                else if (arr.Length == 3)
                {
                    if (arr[0] == "Insert")
                    {
                        int element = int.Parse(arr[1]);
                        int position = int.Parse(arr[2]);
                        nums.Insert(position, element);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
