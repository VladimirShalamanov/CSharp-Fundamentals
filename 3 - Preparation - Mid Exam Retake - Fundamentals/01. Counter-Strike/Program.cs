using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());

            int countWins = 0;

            string command;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                int currDistance = int.Parse(command);

                if (currDistance <= initialEnergy)
                {
                    initialEnergy -= currDistance;
                    countWins++;
                }
                else if (currDistance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWins} won battles and {initialEnergy} energy");
                    return;
                }
                if (countWins % 3 == 0)
                {
                    initialEnergy += countWins;
                }
            }

            Console.WriteLine($"Won battles: {countWins}. Energy left: {initialEnergy}");
        }
    }
}
