using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                        .Split('|')
                        .Reverse()
                        .ToArray();

            string next = string.Join(" ", nums);
            string[] end = next.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", end));
        }
    }
}
