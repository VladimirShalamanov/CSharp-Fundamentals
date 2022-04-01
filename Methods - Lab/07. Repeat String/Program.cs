using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string repeat = RepeatString(word, n);
            Console.WriteLine(repeat);
        }

        static string RepeatString(string word, int n)
        {
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
