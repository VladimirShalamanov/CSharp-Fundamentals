using System;

namespace _4._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char simbol = char.Parse(Console.ReadLine());
                sum += (int)simbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
