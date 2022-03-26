using System;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string simbol = string.Empty;
            int openCount = 0;
            int closeCount = 0;

            for (int i = 0; i < n; i++)
            {
                simbol = Console.ReadLine();

                if (simbol == "(")
                {
                    openCount++;
                }
                else if (simbol == ")")
                {
                    closeCount++;

                    if (openCount - closeCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (openCount == closeCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
