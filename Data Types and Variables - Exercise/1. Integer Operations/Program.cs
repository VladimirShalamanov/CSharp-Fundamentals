using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int sumOne = first + second;
            int sumTwo = sumOne / third;
            int sumThree = sumTwo * fourth;

            Console.WriteLine(sumThree);
        }
    }
}
