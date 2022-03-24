using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal PoundsToDollars = 1.31m;
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * PoundsToDollars;
            Console.WriteLine($"{Math.Round(dollars, 3 ,MidpointRounding.AwayFromZero):f3}");
        }
    }
}
