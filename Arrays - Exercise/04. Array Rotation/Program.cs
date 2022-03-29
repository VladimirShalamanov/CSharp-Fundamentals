using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        private static object split;

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());

            for (int j = 1; j <= rotationsCount; j++)
            {
                int firstElement = arr[0];
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
