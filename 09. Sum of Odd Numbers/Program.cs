using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0;

            for (var i = 0; i < n; i++)
            {
                var currOddNum = 1 + (2 * i);
                Console.WriteLine(currOddNum);
                oddSum += currOddNum;
            }
            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
