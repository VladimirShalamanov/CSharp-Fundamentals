using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            double averageNum = nums.Sum() / nums.Count;
            nums.RemoveAll(x => x <= averageNum);
            nums.Sort();
            nums.Reverse();

            if (nums.Count < 1)
            {
                Console.WriteLine("No");
            }
            else if (nums.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            else if (nums.Count < 5)
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}
