using System;

namespace _4._Refactoring___Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                String numPrime = "true";
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        numPrime = "false";
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", i, numPrime);
            }
        }
    }
}
