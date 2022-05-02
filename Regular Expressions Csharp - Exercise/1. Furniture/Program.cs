using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            List<string> bought = new List<string>();
            decimal total = 0m;

            string cmd;
            while ((cmd = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(cmd, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    decimal price = 
                        decimal.Parse(match.Groups["price"].Value);
                    int quantity =
                        int.Parse(match.Groups["quantity"].Value);

                    bought.Add(name);
                    total += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (string name in bought)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
