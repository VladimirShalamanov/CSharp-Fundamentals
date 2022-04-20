using System;

namespace _01._Experience_Gaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needExperience = double.Parse(Console.ReadLine());
            int countBattles = int.Parse(Console.ReadLine());

            double totalExp = 0;
            int count = 0;

            for (int i = 1; i <= countBattles; i++)
            {
                double currExperience = double.Parse(Console.ReadLine());
                count++;
                totalExp += currExperience;

                if (count % 3 == 0)
                {
                    totalExp += currExperience * 0.15;
                }
                if (count % 5 == 0)
                {
                    totalExp -= currExperience * 0.10;
                }
                if (count % 15 == 0)
                {
                    totalExp += currExperience * 0.05;
                }
                if (totalExp >= needExperience)
                {
                    break;
                }
            }

            if (totalExp >= needExperience)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {needExperience - totalExp:f2} more needed.");
            }
        }
    }
}
