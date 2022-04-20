using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tax_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine()
                .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double taxAgency = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                string[] info = cars[i]
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (info[0] == "family")
                {
                    int years = int.Parse(info[1]);
                    int km = int.Parse(info[2]);

                    double taxlUse = 50 - years * 5;
                    double taxKm = (km / 3000) * 12;
                    double total = taxlUse + taxKm;
                    taxAgency += total;
                    Console.WriteLine($"A {info[0]} car will pay {total:f2} euros in taxes.");
                }
                else if (info[0] == "heavyDuty")
                {
                    int years = int.Parse(info[1]);
                    int km = int.Parse(info[2]);

                    double taxlUse = 80 - years * 8;
                    double taxKm = (km / 9000) * 14;
                    double total = taxlUse + taxKm;
                    taxAgency += total;
                    Console.WriteLine($"A {info[0]} car will pay {total:f2} euros in taxes.");
                }
                else if (info[0] == "sports")
                {
                    int years = int.Parse(info[1]);
                    int km = int.Parse(info[2]);

                    double taxlUse = 100 - years * 9;
                    double taxKm = (km / 2000) * 18;
                    double total = taxlUse + taxKm;
                    taxAgency += total;
                    Console.WriteLine($"A {info[0]} car will pay {total:f2} euros in taxes.");
                }
                else
                {
                    Console.WriteLine("Invalid car type.");
                }
            }

            Console.WriteLine($"The National Revenue Agency will collect {taxAgency:f2} euros in taxes.");
        }
    }
}
