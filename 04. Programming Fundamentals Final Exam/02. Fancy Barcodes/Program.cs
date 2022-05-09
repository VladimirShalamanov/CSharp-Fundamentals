using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"(\@\#{1,})(?<product>[A-Z][a-zA-Z0-9]{4,}[A-Z])(\@\#{1,})");

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    string product = match.Groups["product"].Value;
                    string group = string.Empty;

                    for (int j = 0; j < product.Length; j++)
                    {
                        if (char.IsDigit(product[j]))
                        {
                            group += product[j];
                        }
                    }

                    if (group == "")
                    {
                        group = "00";
                    }

                    Console.WriteLine($"Product group: {group}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
