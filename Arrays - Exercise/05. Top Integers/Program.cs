using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topInteger = new int[arr.Length];
            int topIntIndex = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currNum = arr[i];
                bool isTopInt = true;

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= currNum)
                    {
                        isTopInt = false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    topInteger[topIntIndex] = currNum;
                    topIntIndex++;
                }
            }

            for (int i = 0; i < topIntIndex; i++)
            {
                Console.Write($"{topInteger[i]} ");
            }
        }
    }
}
