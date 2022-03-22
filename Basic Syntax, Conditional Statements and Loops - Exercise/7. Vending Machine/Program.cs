using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double money = 0;
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                else
                {
                    money += coins;
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (money >= 2.0)
                    {
                        money -= 2.0;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money >= 0.7)
                    {
                        money -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money >= 1.5)
                    {
                        money -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money >= 0.8)
                    {
                        money -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money >= 1.0)
                    {
                        money -= 1.0;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            if (product == "End")
            {
                Console.WriteLine($"Change: {money:f2}");
            }
        }
    }
}
