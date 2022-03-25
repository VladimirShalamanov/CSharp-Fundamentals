using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());

            int days = 0;
            int totalSpice = 0;
            if (startYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
            else
            {
                while (startYield >= 100)
                {
                    days++;
                    totalSpice += startYield - 26;
                    startYield -= 10;
                }

                totalSpice -= 26;
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
        }
    }
}
