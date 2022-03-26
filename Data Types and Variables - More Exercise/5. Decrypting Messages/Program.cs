using System;


namespace _5._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int letterNum = input + key;
                char letter = (char)(letterNum);
                word += letter.ToString();
            }

            Console.WriteLine(word); 
        }
    }
}
