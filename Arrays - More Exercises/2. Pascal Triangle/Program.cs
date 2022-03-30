using System;

namespace _2._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] currArr = { 1 };

            for (int row = 1; row < rows; row++)
            {
                int[] newArr = new int[currArr.Length + 1];

                for (int i = 0; i < currArr.Length; i++)
                {
                    newArr[i] += currArr[i];
                    newArr[i + 1] = currArr[i];
                }

                Console.WriteLine(String.Join(' ', currArr));
                currArr = newArr;
            }

            Console.WriteLine(String.Join(' ', currArr));
        }
    }
}
