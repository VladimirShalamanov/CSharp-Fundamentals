using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            List<string> locations = new List<string>();

            Regex regex = new Regex(@"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)");

            int travelPoints = 0;

            MatchCollection matches = regex.Matches(map);
            foreach (Match match in matches)
            {
                string currDestionation = match.Groups["destination"].Value;

                locations.Add(currDestionation);
                travelPoints += currDestionation.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", locations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
