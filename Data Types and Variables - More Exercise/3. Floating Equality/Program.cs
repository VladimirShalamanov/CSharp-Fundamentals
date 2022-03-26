using System;

namespace _3._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < eps)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
