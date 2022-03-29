using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int winCount = 0;
            int index = 0;
            string num = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;

                    if (count > winCount)
                    {
                        winCount = count;
                        index = i;
                        num = arr[i].ToString();
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = 0; i <= winCount; i++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
