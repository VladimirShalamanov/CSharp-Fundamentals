using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < num.Length; i++)
            {
                int currNum = num[i];

                if (currNum % 2 == 0)
                {
                    even += currNum;
                }
                else
                {
                    odd += currNum;
                }
            }

            int difference = even - odd;

            Console.WriteLine(difference);
        }
    }
}
