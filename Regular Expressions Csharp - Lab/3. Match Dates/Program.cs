using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(inputs);

            foreach (Match date in match)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}," +
                    $" Month: {date.Groups["month"].Value}," +
                    $" Year: {date.Groups["year"].Value}");
            }
        }
    }
}
