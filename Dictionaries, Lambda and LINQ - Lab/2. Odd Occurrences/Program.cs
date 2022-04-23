using System;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordLowCase = word.ToLower();
                if (counts.ContainsKey(wordLowCase))
                {
                    counts[wordLowCase]++;
                }
                else
                {
                    counts.Add(wordLowCase, 1);
                }
            }
            
            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
