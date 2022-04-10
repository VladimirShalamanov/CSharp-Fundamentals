using System;

namespace _4._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            GetTribonacii(num);
        }

        static void GetTribonacii(int num)
        {
            int a = 0;
            int b = 0;
            int c = 1;
            int d = a + b + c;
            Console.Write("1 1");
            for (int i = 2; i < num; i++)
            {
                a = b;
                b = c;
                c = d;
                d = a + b + c;
                Console.Write(" " + d);
            }
        }
    }
}
