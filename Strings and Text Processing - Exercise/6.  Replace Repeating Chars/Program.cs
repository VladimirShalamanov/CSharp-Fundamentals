using System;
using System.Collections.Generic;

namespace _6.__Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            List<string> all = new List<string>();

            string st = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                string currStr = words[i].ToString();

                if (currStr != st)
                {
                    all.Add(currStr);
                    st = currStr;
                }
            }

            Console.WriteLine(string.Join("", all));
        }
    }
}
