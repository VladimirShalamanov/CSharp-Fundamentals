using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "end")
            {
                string reverse = string.Empty;
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reverse += line[i];
                }

                Console.WriteLine($"{line} = {reverse}");
            }
        }
    }
}
