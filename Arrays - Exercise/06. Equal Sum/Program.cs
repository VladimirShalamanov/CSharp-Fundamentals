using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int left = 0; left <= i - 1; left++)
                {
                    leftSum += arr[left];
                }

                for (int right = i + 1; right <= arr.Length - 1; right++)
                {
                    rightSum += arr[right];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum = 0;
                rightSum = 0;
            }

            Console.WriteLine("no");
        }
    }
}
