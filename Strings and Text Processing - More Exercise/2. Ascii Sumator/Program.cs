using System;

namespace _2._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string random = Console.ReadLine();

            int start = (int)first;
            int end = (int)second;

            int sum = 0;
            for (int i = 0; i < random.Length; i++)
            {
                int curr = random[i];

                if (curr > start && curr < end)
                {
                    sum += curr;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
