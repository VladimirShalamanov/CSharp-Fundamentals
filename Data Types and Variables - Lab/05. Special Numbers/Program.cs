using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                int currNumSum = 0;

                while (currentNum != 0)
                {
                    currNumSum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool isSpecial = currNumSum == 5 || currNumSum == 7 || currNumSum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
