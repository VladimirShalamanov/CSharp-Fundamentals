using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int divisible = 0;
            if (num % 10 == 0)
            {
                divisible = 10;
            }
            else if (num % 7 == 0)
            {
                divisible = 7;
            }
            else if (num % 6 == 0)
            {
                divisible = 6;
            }
            else if (num % 3 == 0)
            {
                divisible = 3;
            }
            else if (num % 2 == 0)
            {
                divisible = 2;
            }
            if (divisible >= 2)
            {
                Console.WriteLine($"The number is divisible by {divisible}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
