using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> cards1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> cards2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (cards1[0] > cards2[0])
                {
                    cards1.Add(cards1[0]);
                    cards1.Add(cards2[0]);
                }
                else if (cards1[0] < cards2[0])
                {
                    cards2.Add(cards2[0]);
                    cards2.Add(cards1[0]);
                }

                cards1.Remove(cards1[0]);
                cards2.Remove(cards2[0]);

                if (cards1.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
                    break;
                }
                else if (cards2.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
                    break;
                }
            }
        }
    }
}
