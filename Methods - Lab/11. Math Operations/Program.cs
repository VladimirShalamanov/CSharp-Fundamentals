using System;

namespace _11._Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string simbol = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double end = Calculate(a, simbol, b);
            Console.WriteLine(end);
        }

        static double Calculate(int a, string simbol, int b)
        {
            double result = 0;

            switch (simbol)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
