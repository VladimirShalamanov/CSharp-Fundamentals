using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                char digit = nums[i];
                sum += int.Parse(digit.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
