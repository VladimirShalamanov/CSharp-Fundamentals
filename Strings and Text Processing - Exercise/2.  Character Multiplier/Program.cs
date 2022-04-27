using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.__Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string name1 = names[0];
            string name2 = names[1];
            int sum = 0;

            if (name1.Length == name2.Length)
            {
                for (int i = 0; i < name1.Length;)
                {
                    for (int j = 0; j < name2.Length; j++)
                    {
                        sum += (int)name1[i] * (int)name2[j];
                        i++;
                    }
                    break;
                }
            }

            else if (name1.Length < name2.Length)
            {
                string name2Start = name2.Substring(0, name1.Length);
                string name2End = name2.Substring(name1.Length);
                for (int i = 0; i < name1.Length;)
                {
                    for (int j = 0; j < name2Start.Length; j++)
                    {
                        sum += (int)name1[i] * (int)name2Start[j];
                        i++;
                    }
                    break;
                }
                for (int i = 0; i < name2End.Length; i++)
                {
                    sum += (int)name2End[i];
                }

            }
            else if (name1.Length > name2.Length)
            {
                string name1Start = name1.Substring(0, name2.Length);
                string name1End = name1.Substring(name2.Length);
                for (int i = 0; i < name2.Length;)
                {
                    for (int j = 0; j < name1Start.Length; j++)
                    {
                        sum += (int)name2[i] * (int)name1Start[j];
                        i++;
                    }
                    break;
                }
                for (int i = 0; i < name1End.Length; i++)
                {
                    sum += (int)name1End[i];
                }

            }

            Console.WriteLine(sum);
        }
    }
}
