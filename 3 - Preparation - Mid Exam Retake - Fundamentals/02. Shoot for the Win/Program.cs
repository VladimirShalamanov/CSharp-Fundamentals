using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int countTargets = 0;

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int indexShot = int.Parse(command);

                if (indexShot >= 0 && indexShot < targets.Count)
                {
                    if (targets[indexShot] >= 0)
                    {
                        int saveIndex = targets[indexShot];
                        targets[indexShot] = -1;
                        countTargets++;

                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] >= 0)
                            {
                                if (targets[i] > saveIndex)
                                {
                                    targets[i] -= saveIndex;
                                }
                                else if (targets[i] <= saveIndex)
                                {
                                    targets[i] += saveIndex;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {countTargets} -> {string.Join(" ", targets)}");
        }
    }
}
