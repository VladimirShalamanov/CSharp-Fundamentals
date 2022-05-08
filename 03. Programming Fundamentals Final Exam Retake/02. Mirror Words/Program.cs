using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(\@|\#)(?<first>[A-Za-z]{3,})(\1{2})(?<second>[A-Za-z]{3,})(\1)");

            MatchCollection matches = regex.Matches(text);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            Dictionary<string, string> words = new Dictionary<string, string>();

            foreach (Match item in matches)
            {
                string first = item.Groups["first"].Value;
                string second = item.Groups["second"].Value;

                char[] charArr = second.ToCharArray();
                Array.Reverse(charArr);
                string secondReverse = new string(charArr);

                if (first == secondReverse)
                {
                    words[first] = second;
                }
            }

            if (words.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                string dictOutput = string.Join(", ", words.Select(x => x.Key + " <=> " + x.Value).ToArray());

                Console.WriteLine(dictOutput);
            }
        }
    }
}
