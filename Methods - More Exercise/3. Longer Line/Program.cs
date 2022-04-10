using System;

namespace _3._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());

            double num5 = double.Parse(Console.ReadLine());
            double num6 = double.Parse(Console.ReadLine());
            double num7 = double.Parse(Console.ReadLine());
            double num8 = double.Parse(Console.ReadLine());

            GetLongerLine(num1, num2, num3, num4, num5, num6, num7, num8);
        }

        static void Closer(double x, double y, double z, double p)
        {
            if (x * x + y * y <= z * z + p * p)
            {
                Console.WriteLine($"({x}, {y})({z}, {p})");
            }
            else
            {
                Console.WriteLine($"({z}, {p})({x}, {y})");
            }
        }

        static void GetLongerLine(double a1, double b1, double a2, double b2, double a3, double b3, double a4, double b4)
        {
            double point1 = Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2);
            double point2 = Math.Pow(a3 - a4, 2) + Math.Pow(b3 - b4, 2);

            if (point1 >= point2)
            {
                Closer(a1, b1, a2, b2);
            }
            else
            {
                Closer(a3, b3, a4, b4);
            }

        }
    }
}
