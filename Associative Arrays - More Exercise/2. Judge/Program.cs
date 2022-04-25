using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            var totalPoints = new Dictionary<string, int>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "no more time")
            {
                string[] arr = cmd
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string username = arr[0];
                string contest = arr[1];
                int points = int.Parse(arr[2]);
                bool mustSum = false;

                if (!dict.ContainsKey(contest))
                {
                    dict[contest] = new Dictionary<string, int>();
                    dict[contest][username] = points;
                    mustSum = true;
                }
                else
                {
                    if (!dict[contest].ContainsKey(username))
                    {
                        dict[contest][username] = points;
                        mustSum = true;
                    }
                    else
                    {
                        int currPoints = dict[contest][username];
                        if (currPoints < points)
                        {
                            dict[contest][username] = points;
                            points -= currPoints;
                            mustSum = true;
                        }
                    }
                }
                if (!totalPoints.ContainsKey(username))
                {
                    totalPoints[username] = 0;
                }
                if (mustSum)
                {
                    totalPoints[username] += points;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} participants");
                int cnt = 1;
                foreach (var pair in kvp.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{cnt}. {pair.Key} <::> {pair.Value}");
                    cnt++;
                }
            }
            Console.WriteLine("Individual standings:");
            int cr = 1;
            foreach (var kvp in totalPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{cr}. {kvp.Key} -> {kvp.Value}");
                cr++;
            }
        }
    }
}
