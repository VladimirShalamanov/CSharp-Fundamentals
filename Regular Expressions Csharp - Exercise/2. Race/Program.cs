using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, double>();

            string[] players = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string player in players)
            {
                dict[player] = 0;
            }

            string name = @"(?<name>[A-Za-z])";
            string digit = @"(?<digit>\d)";

            string cmd;
            while ((cmd = Console.ReadLine()) != "end of race")
            {
                MatchCollection matchName = Regex.Matches(cmd, name);
                
                string currName = string.Empty;
                double km = 0;

                foreach (Match match in matchName)
                {
                    currName += match.Value;
                }
                if (dict.ContainsKey(currName))
                {
                    MatchCollection matchDigit = Regex.Matches(cmd, digit);
                    foreach (Match item in matchDigit)
                    {
                        km += double.Parse(item.Value);
                    }
                    dict[currName] += km;
                }
            }

            dict = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine($"1st place: {dict.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {dict.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {dict.Keys.ElementAt(2)}");
        }
    }
}

