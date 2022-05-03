using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"([\||\#])(?<food>[A-Za-z]+( [A-Za-z]+)?)(\1)(?<date>\d{2}\/\d{2}\/\d{2})(\1)(?<calories>\d{1,5})(\1)");

            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            int totalCalories = 0;

            foreach (Match match in matches)
            {
                int currCalories = int.Parse(match.Groups["calories"].Value);
                totalCalories += currCalories;
            }

            int daysLast = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysLast} days!");

            foreach (Match match in matches)
            {
                string food = match.Groups["food"].Value;
                string date = match.Groups["date"].Value;
                string calories = match.Groups["calories"].Value;

                Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
