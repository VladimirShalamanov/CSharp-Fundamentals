using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double petKg = double.Parse(Console.ReadLine());

            double food = foodKg * 1000;
            double hay = hayKg * 1000;
            double cover = coverKg * 1000;
            double pet = petKg * 1000;

            int days = 0;

            while (days != 30)
            {
                days++;
                if (food > 0)
                {
                    food -= 300;
                }
                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                if (days % 2 == 0)
                {
                    if (hay > 0)
                    {
                        hay -= food * 0.05;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;
                    }
                }
                if (days % 3 == 0)
                {
                    if (cover > 0)
                    {
                        cover -= pet / 3;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;
                    }
                }
            }
            if (food >= 0 && hay >= 0 && cover >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:f2}, Cover: {cover / 1000:f2}.");
            }
        }
    }
}
