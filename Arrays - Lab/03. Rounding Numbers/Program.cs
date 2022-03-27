using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split();

            double[] roundedNums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = double.Parse(nums[i]);
            }

            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{roundedNums[i]} => {Math.Round(roundedNums[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
