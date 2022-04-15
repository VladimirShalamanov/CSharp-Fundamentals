using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double priceWithoutTaxes = 0;
            double taxes = 0;
            double totalPrice = 0;

            while (command != "regular" && command != "special")
            {
                double currPrice = double.Parse(command);

                if (currPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else if (currPrice > 0)
                {
                    priceWithoutTaxes += currPrice;
                }

                command = Console.ReadLine();
            }

            if (priceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (command == "special")
            {
                taxes = priceWithoutTaxes * 0.2;
                totalPrice = priceWithoutTaxes + taxes;
                totalPrice *= 0.9;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
            else if (command == "regular")
            {
                taxes = priceWithoutTaxes * 0.2;
                totalPrice = priceWithoutTaxes + taxes;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
