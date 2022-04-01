using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            if (values == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2));
            }
            else if (values == "char")
            {
                char simbol1 = char.Parse(Console.ReadLine());
                char simbol2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(simbol1, simbol2));
            }
            else if (values == "string")
            {
                string name1 = Console.ReadLine();
                string name2 = Console.ReadLine();
                Console.WriteLine(GetMax(name1, name2));
            }
        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GetMax(char simbol1, char simbol2)
        {
            return (simbol1 > simbol2) ? simbol1 : simbol2;
        }

        static string GetMax(string name1, string name2)
        {
            if (name1.CompareTo(name2) > 0)
            {
                return name1;
            }
            else
            {
                return name2;
            }
        }
    }
}
