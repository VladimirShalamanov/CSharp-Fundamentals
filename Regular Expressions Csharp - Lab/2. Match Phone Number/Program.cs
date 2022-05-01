using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();

            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(phones);

            var matched = match
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matched));
        }
    }
}
