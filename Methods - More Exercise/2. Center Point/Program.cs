using System;

namespace _2._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());

            GetCenterPoint(num1, num2, num3, num4);
        }

        private static void GetCenterPoint(double num1, double num2, double num3, double num4)
        {
            double point1 = Math.Abs(num1) + Math.Abs(num2);
            double point2 = Math.Abs(num3) + Math.Abs(num4);

            if (point1 > point2)
            {
                Console.WriteLine($"({num3}, {num4})");
            }
            else if (point1 < point2)
            {
                Console.WriteLine($"({num1}, {num2})");
            }
            else if (point1 == point2)
            {
                Console.WriteLine($"({num1}, {num2})");
            }
        }
    }
}
