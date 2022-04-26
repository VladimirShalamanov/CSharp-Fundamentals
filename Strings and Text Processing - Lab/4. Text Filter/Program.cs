using System;

namespace _4._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], new string ('*', words[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
