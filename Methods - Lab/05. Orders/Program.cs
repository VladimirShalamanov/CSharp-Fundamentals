using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;

            switch (product)
            {
                case "coffee":
                    coffee(quantity, coffeePrice);
                    break;
                case "water":
                    water(quantity, waterPrice);
                    break;
                case "coke":
                    coke(quantity, cokePrice);
                    break;
                case "snacks":
                    snacks(quantity, snacksPrice);
                    break;
            }

            static void coffee(int quantity, double coffeePrice)
            {
                Console.WriteLine($"{quantity * coffeePrice:f2}");
            }
            static void water(int quantity, double waterPrice)
            {
                Console.WriteLine($"{quantity * waterPrice:f2}");
            }
            static void coke(int quantity, double cokePrice)
            {
                Console.WriteLine($"{quantity * cokePrice:f2}");
            }
            static void snacks(int quantity, double snacksPrice)
            {
                Console.WriteLine($"{quantity * snacksPrice:f2}");
            }
        }
    }
}
