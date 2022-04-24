using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> productAndPrice = new Dictionary<string, List<double>>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "buy")
            {
                string[] arr = cmd.Split(' ').ToArray();
                string product = arr[0];
                double price = double.Parse(arr[1]);
                int num = int.Parse(arr[2]);

                if (!productAndPrice.ContainsKey(product))
                {
                    productAndPrice[product] = new List<double>()
                    {
                        price, num
                    };
                }
                else
                {
                    productAndPrice[product][0] = price;
                    productAndPrice[product][1] += num;
                }
            }

            foreach (var item in productAndPrice)
            {
                string products = item.Key.ToString();
                double sum = item.Value[0] * item.Value[1];
                Console.WriteLine($"{products} -> {sum:f2}");
            }
        }
    }
}
