using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (second > 10)
            {
                Console.WriteLine($"{first} X {second} = {first * second}");
            }
            else
            {
                for (int i = second; i <= 10; i++)
                {
                    Console.WriteLine($"{first} X {i} = {first * i}");
                }
            }
        }
    }
}
