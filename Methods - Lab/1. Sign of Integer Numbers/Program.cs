using System;

namespace Lab___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSing(int.Parse(Console.ReadLine()));
        }

        static void PrintSing(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (0 > number)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }

    }
}
