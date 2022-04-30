using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string cmd;
            while ((cmd = Console.ReadLine()) != "find")
            {
                List<char> charInput = cmd.ToList();
                int keyL = 0;
                for (int i = 0; i < charInput.Count; i++)
                {
                    charInput[i] = Convert.ToChar(charInput[i] - arr[keyL]);
                    keyL++;
                    if (keyL == arr.Length)
                    {
                        keyL = 0;
                    }

                }

                int typeStart = charInput.IndexOf('&');
                int typeEnd = charInput.LastIndexOf('&');
                string type = charInput.ToString().Substring(typeStart + 1, typeEnd - typeStart - 1);

                int coordinatesStart = charInput.IndexOf('<');
                int coordinatesEnd = charInput.IndexOf('>');
                string coordinates = charInput.ToString().Substring(coordinatesStart + 1, coordinatesEnd - coordinatesStart - 1);

                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
