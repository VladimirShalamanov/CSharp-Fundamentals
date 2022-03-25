using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int currPower = n;
            int targets = 0;

            while (currPower >= m)
            {
                currPower -= m;
                targets++;

                if (currPower == n * 0.5 && y != 0)
                {
                    currPower /= y;
                }
            }

            Console.WriteLine(currPower);
            Console.WriteLine(targets);
        }
    }
}
