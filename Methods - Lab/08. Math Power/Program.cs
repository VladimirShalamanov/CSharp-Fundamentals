using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double total = ToPower(number, power);
            Console.WriteLine(total);
        }

        static double ToPower(double number, int power)
        {
            double result = 0d;

            result = Math.Pow(number, power);
            return result;
        }
    }
}
