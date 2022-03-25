using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestKeg = 0;
            string modelKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    modelKeg = model;
                }
            }

            Console.WriteLine(modelKeg);
        }
    }
}
