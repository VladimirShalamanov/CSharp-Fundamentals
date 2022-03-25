using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int waterTank = 255;
            int sumWater = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantitieWater = int.Parse(Console.ReadLine());
                sumWater += quantitieWater;

                if (sumWater > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumWater -= quantitieWater;
                }
            }

            Console.WriteLine(sumWater);
        }
    }
}
