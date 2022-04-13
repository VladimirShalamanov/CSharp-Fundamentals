using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string type = arr[0];
                if (type == "Add")
                {
                    nums.Add(int.Parse(arr[1]));
                }
                else if (type == "Insert")
                {
                    int number = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    if (index < 0 || index >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    nums.Insert(index, number);
                }
                else if (type == "Remove")
                {
                    int remove = int.Parse(arr[1]);
                    if (remove < 0 || remove >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    nums.RemoveAt(remove);
                }
                else if (type == "Shift")
                {
                    string leftOrRight = arr[1];
                    int count = int.Parse(arr[2]);
                    int loopCnt = count % nums.Count;
                    if (leftOrRight == "left")
                    {
                        for (int i = 1; i <= loopCnt; i++)
                        {
                            int firstElement = nums.First();
                            nums.Remove(firstElement);
                            nums.Add(firstElement);
                        }
                    }
                    else if (leftOrRight == "right")
                    {
                        for (int i = 1; i <= loopCnt; i++)
                        {
                            int lastElement = nums.Last();
                            nums.RemoveAt(nums.Count - 1);
                            nums.Insert(0, lastElement);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
