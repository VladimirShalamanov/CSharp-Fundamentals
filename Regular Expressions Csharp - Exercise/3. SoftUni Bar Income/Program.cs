using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^%$|.]*?\<(?<product>\w+)\>[^%$|.]*?\|(?<quantity>\d+)\|[^%$|.]*?(?<price>\d+(\.\d+)?)\$";

            decimal total = 0m;
            string cmd;
            while ((cmd = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(cmd, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);

                    decimal totalP = quantity * price;
                    total += totalP;

                    Console.WriteLine($"{name}: {product} - {totalP:f2}");
                }
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
