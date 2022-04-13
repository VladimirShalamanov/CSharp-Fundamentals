using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;
            int removeElement = 0;

            while (num.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                int firstElement = num[0];
                int lastElement = num[num.Count - 1];

                if (index < 0)
                {
                    removeElement = firstElement;
                    num.RemoveAt(0);
                    num.Insert(0, lastElement);
                }
                else if (index > num.Count - 1)
                {
                    removeElement = lastElement;
                    num.RemoveAt(num.Count - 1);
                    num.Add(firstElement);
                }
                else
                {
                    removeElement = num[index];
                    num.RemoveAt(index);
                }
                sum += removeElement;

                for (int i = 0; i < num.Count; i++)
                {
                    int currNum = num[i];
                    if (currNum <= removeElement)
                    {
                        currNum += removeElement;
                        num[i] = currNum;
                    }
                    else
                    {
                        currNum -= removeElement;
                        num[i] = currNum;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
