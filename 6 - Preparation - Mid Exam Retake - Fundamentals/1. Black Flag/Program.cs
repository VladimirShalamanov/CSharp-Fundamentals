using System;

namespace _1._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysLasts = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;
            int count = 0;
            while(count != daysLasts)
            {
                count++;
                totalPlunder += (double)dailyPlunder;
                if (count % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.5;
                }
                if (count % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else if (totalPlunder < expectedPlunder)
            {
                Console.WriteLine($"Collected only {totalPlunder / expectedPlunder * 100:f2}% of the plunder.");
            }
        }
    }
}
