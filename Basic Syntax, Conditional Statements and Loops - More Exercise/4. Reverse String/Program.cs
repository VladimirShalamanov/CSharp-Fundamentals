using System;

namespace _4._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reverse = string.Empty;

            for (int reverseIndex = word.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                reverse += word[reverseIndex];
            }

            Console.WriteLine(reverse);
        }
    }
}
