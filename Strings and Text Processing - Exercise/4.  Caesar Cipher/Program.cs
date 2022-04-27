using System;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                int newNum = (int)text[i] + 3;
                char newCh = (char)newNum;
                newText += newCh;
            }

            Console.WriteLine(newText);
        }
    }
}
