using System;
using System.Linq;

namespace _8._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                string name = word[i];
                char before = name[0];
                char after = name[name.Length - 1];
                name = name.Remove(0, 1);
                name = name.Remove(name.Length - 1, 1);
                double nums = double.Parse(name);

                int positionBefore = (int)before;
                int positionAfter = (int)after;
                //96
                if (char.IsLower(before))
                {
                    nums = nums * (positionBefore - 96);
                }
                else if (char.IsUpper(before))
                {
                    nums = nums / (positionBefore - 64);
                }
                //64
                if (char.IsLower(after))
                {
                    nums = nums + (positionAfter - 96);
                }
                else if (char.IsUpper(after))
                {
                    nums = nums - (positionAfter - 64);
                }

                sum += nums;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
