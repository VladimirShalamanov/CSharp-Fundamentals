using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sumEvenNum = GetSumOfEvenDigits(input);
            int sumOddsNum = GetSumOfOddNumber(input);

            int result = EvenAndOdds(sumEvenNum, sumOddsNum);
            Console.WriteLine(result);
        }

        static int EvenAndOdds(int evenNum, int oddNum)
        {
            int result = evenNum * oddNum;
            return result;
        }

        static int GetSumOfOddNumber(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currNum = number % 10;
                number = number / 10;

                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currNum = number % 10;
                number = number / 10;

                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
            }

            return sum;
        }
    }
}
