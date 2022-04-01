using System;

namespace Exercise___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int[n];

            int totalPass = 0;

            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                totalPass += passengers[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{passengers[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(totalPass);
        }
    }
}
