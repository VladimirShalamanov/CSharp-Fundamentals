using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arr = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = arr[0];
                if (type == "swap")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);
                    int in1 = nums[index1];
                    int in2 = nums[index2];
                    nums.RemoveAt(index1);
                    nums.Insert(index1, in2);
                    nums.RemoveAt(index2);
                    nums.Insert(index2, in1);
                }
                else if (type == "multiply")
                {
                    int index1 = int.Parse(arr[1]);
                    int index2 = int.Parse(arr[2]);
                    int in1 = nums[index1];
                    int in2 = nums[index2];
                    int multiply = in1 * in2;
                    nums.RemoveAt(index1);
                    nums.Insert(index1, multiply);
                }
                else if (type == "decrease")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        int temp = nums[i] - 1;
                        nums[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
