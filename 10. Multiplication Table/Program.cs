﻿using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int mat = num * i;
                Console.WriteLine($"{num} X {i} = {mat}");
            }
        }
    }
}
