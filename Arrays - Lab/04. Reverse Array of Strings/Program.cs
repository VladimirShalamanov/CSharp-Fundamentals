using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();

            Array.Reverse(items);

            Console.WriteLine(string.Join(" ", items));
        }
    }
}
