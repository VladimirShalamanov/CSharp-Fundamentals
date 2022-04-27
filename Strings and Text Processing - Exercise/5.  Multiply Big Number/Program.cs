using System;
using System.Collections.Generic;

namespace _5.__Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumSt = Console.ReadLine();
            bigNumSt = bigNumSt.TrimStart(new char[] {'0'});
            char[] bigNum = bigNumSt.ToCharArray();
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }
            List<string> newNum = new List<string>();

            int parse = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                parse = (int.Parse(Convert.ToString(bigNum[i])) * num) + parse;
                newNum.Insert(0, (parse % 10).ToString());
                parse /= 10;
            }

            if (parse > 0)
            {
                Console.WriteLine($"{parse}{string.Join("", newNum)}");
            }
            else
            {
                Console.WriteLine(string.Join("", newNum));
            }
        }
    }
}
