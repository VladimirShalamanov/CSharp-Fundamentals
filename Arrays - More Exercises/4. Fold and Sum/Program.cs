using System;
using System.Linq;

namespace _4._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = arr.Length / 4;

            int[] lowerRow = new int[k * 2];
            int lowerRowIndex = 0;

            int[] upperRow = new int[k * 2];
            int upperRowIndex = 0;

            for (int i = k - 1; i >= 0; i--)
            {
                upperRow[upperRowIndex] = arr[i];
                upperRowIndex++;
            }

            for (int i = arr.Length - 1; i > 3 * k - 1; i--)
            {
                upperRow[upperRowIndex] = arr[i];
                upperRowIndex++;
            }

            Console.WriteLine();

            for (int i = k; i < 3 * k; i++)
            {
                lowerRow[lowerRowIndex] = arr[i];
                lowerRowIndex++;
            }

            for (int i = 0; i < upperRow.Length; i++)
            {
                Console.Write($"{upperRow[i] + lowerRow[i]} ");
            }

            Console.WriteLine();
        }
    }
}
