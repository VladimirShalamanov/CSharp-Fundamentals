using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] info = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int bomb = info[0];
            int power = info[1];

            while (true)
            {
                int indexBomb = nums.IndexOf(bomb);
                if (indexBomb == -1)
                {
                    break;
                }
                int rightIndex = indexBomb + power;
                for (int cnt = indexBomb; cnt <= rightIndex; cnt++)
                {
                    if (indexBomb >= nums.Count)
                    {
                        break;
                    }

                    nums.RemoveAt(indexBomb);
                }

                int leftIndex = indexBomb - power;
                if (leftIndex < 0)
                {
                    leftIndex = 0;
                }
                for (int cnt = leftIndex; cnt < indexBomb; cnt++)
                {
                    if (leftIndex >= nums.Count)
                    {
                        break;
                    }

                    nums.RemoveAt(leftIndex);
                }
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
