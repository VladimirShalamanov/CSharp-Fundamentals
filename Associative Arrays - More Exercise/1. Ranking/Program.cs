using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<List<string>, List<string>> bookshelves = new Dictionary<List<string>, List<string>>();
            Dictionary<List<string>, List<int>> namePoits = new Dictionary<List<string>, List<int>>();

            string cmdOne;
            while ((cmdOne = Console.ReadLine()) != "end of contests")
            {
                string[] arr = cmdOne
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                bookshelves[new List<string>() { arr[0], arr[1] }] = new List<string>() { string.Empty, string.Empty };
            }

            string cmdTwo;
            while ((cmdTwo = Console.ReadLine()) != "end of submissions")
            {
                string[] arr = cmdTwo
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contest = arr[0];
                string password = arr[1];
                string username = arr[2];
                string points = arr[3];

                List<string> currList = new List<string>() { contest, password };
                List<string> names = new List<string>() { username };
                List<int> poiList = new List<int>() { int.Parse(points) };
                if (!bookshelves.ContainsKey(currList))
                {
                    bookshelves[currList] = new List<string>() { username, points };
                    int iPoi = int.Parse(points);
                    namePoits[names] = poiList;
                    continue;
                }
                if (bookshelves[currList].Any(x => x == username))
                {
                    string srtPoi = bookshelves[currList][2];
                    int poi = int.Parse(srtPoi);
                    int currPoi = int.Parse(points);

                    if (currPoi > poi)
                    {
                        string newPoits = currPoi.ToString();
                        bookshelves[currList][2] = newPoits;
                        namePoits[names] = poiList;
                        continue;
                    }
                }
            }

            Dictionary<string, int> usersTootalPoints = new Dictionary<string, int>();
            foreach (var kvp in namePoits)
            {
                usersTootalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            int maxPoints = usersTootalPoints
                .Values
                .Max();

            foreach (var kvp in usersTootalPoints)
            {
                if (kvp.Value == maxPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }

            Console.WriteLine("Ranking:");
            
            foreach (var kvp in bookshelves)
            {
                Console.WriteLine(kvp.Key[1]);
                Console.WriteLine(string.Join(Environment.NewLine, kvp.Value
                    .OrderByDescending(x => x)
                    .Select(a => $"#  {a.Key[0]} -> {a.Value}")));
            }
        }
    }
}