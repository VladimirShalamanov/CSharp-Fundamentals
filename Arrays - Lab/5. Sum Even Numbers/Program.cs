using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currNum = num[i];
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
