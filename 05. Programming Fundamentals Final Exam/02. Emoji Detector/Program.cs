using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regexDigit = new Regex(@"[0-9]");
            Regex regexNames = new Regex(@"(\:{2}|\*{2})(?<name>[A-Z][a-z]{2,})(\1)");

            MatchCollection digit = regexDigit.Matches(text);
            MatchCollection names = regexNames.Matches(text);

            int points = 1;
            foreach (Match match in digit)
            {
                points *= int.Parse(match.Value);
            }

            List<string> allNames = new List<string>();
            foreach (Match match in names)
            {
                int currPointsName = 0;
                string currName = match.Groups["name"].Value;
                for (int i = 0; i < currName.Length; i++)
                {
                    char ch = currName[i];
                    currPointsName += ch;
                }

                if (currPointsName > points)
                {
                    allNames.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {points}");
            Console.WriteLine($"{names.Count} emojis found in the text. The cool ones are:");
            foreach (var name in allNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
