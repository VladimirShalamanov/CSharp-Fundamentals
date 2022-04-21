using System;
using System.Linq;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(0, words.Length);

                var a = words[pos2];
                var b = words[pos1];
                words[pos2] = b;
                words[pos1] = a;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
