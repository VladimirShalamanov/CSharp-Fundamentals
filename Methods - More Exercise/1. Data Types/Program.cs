using System;

namespace More_Exercise___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();

            GetResultType(type, input);
        }

        static void GetResultType(string type, string input)
        {
            if (type == "int")
            {
                int num = int.Parse(input);
                num *= 2;
                Console.WriteLine(num);
            }
            else if (type == "real")
            {
                double num = double.Parse(input);
                num *= 1.5;
                Console.WriteLine($"{num:f2}");
            }
            else if (type == "string")
            {
                string word = input;
                Console.WriteLine($"${word}$");
            }
        }
    }
}
