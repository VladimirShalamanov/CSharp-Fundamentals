using System;

namespace _5._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetAnswear(num1, num2, num3);
        }

        static void GetAnswear(int n1, int n2, int n3)
        {
            int cout = 0;
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
                return;
            }
            if (n1 < 0)
            {
                cout++;
            }
            if (n2 < 0)
            {
                cout++;
            }
            if (n3 < 0)
            {
                cout++;
            }
            if (cout % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            if (cout % 2 != 0)
            {
                Console.WriteLine("negative");
            }
        }
    }
}
