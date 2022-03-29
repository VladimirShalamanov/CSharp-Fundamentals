using System;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[fieldSize];

            string[] occupiedIndex = Console.ReadLine().Split();
            for (int i = 0; i < occupiedIndex.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndex[i]);
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladyBugField[currentIndex] = 1;
                }
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                bool isFirst = true;
                int currIndex = int.Parse(command[0]);
                while (currIndex >= 0 && currIndex < fieldSize && ladyBugField[currIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugField[currIndex] = 0;
                        isFirst = false;
                    }

                    string direction = command[1];
                    int flightLength = int.Parse(command[2]);
                    if (direction == "left")
                    {
                        currIndex -= flightLength;
                        if (currIndex >= 0 && currIndex < fieldSize)
                        {
                            if (ladyBugField[currIndex] == 0)
                            {
                                ladyBugField[currIndex] = 1;
                                break;
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        currIndex += flightLength;
                        if (currIndex >= 0 && currIndex < fieldSize)
                        {
                            if (ladyBugField[currIndex] == 0)
                            {
                                ladyBugField[currIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", ladyBugField));
        }
    }
}
