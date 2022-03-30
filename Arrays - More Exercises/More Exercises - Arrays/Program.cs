using System;

namespace More_Exercises___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                int inputLength = input.Length;
                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char currChar = input[j];
                    switch (currChar)
                    {
                        case 'a': case 'e': case 'i': case 'o': case 'u':
                        case 'A': case 'E': case 'I': case 'O': case 'U':
                            sum += currChar * inputLength;
                            break;
                        default:
                            sum += currChar / inputLength;
                            break;
                    }
                }

                numbers[i] = sum;
            }

            Array.Sort(numbers);

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
