using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> resours = new Dictionary<char, int>();

            string text = Console.ReadLine();

            foreach(var ch in text)
            {
                if (!resours.ContainsKey(ch))
                {
                    resours.Add(ch, 1);
                    continue;
                }
                resours[ch]++;
            }
            foreach(var ch in resours.Where(x => x.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
