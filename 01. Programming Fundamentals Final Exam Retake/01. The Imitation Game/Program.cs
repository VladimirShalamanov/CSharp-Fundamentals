using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string crypedMess = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Decode")
            {
                string[] arr = cmd
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = arr[0];

                if (type == "ChangeAll")
                {
                    string subStr = arr[1];
                    string replacement = arr[2];

                    crypedMess = crypedMess.Replace(subStr, replacement);
                }
                else if (type == "Insert")
                {
                    int index = int.Parse(arr[1]);
                    string value = arr[2];

                    crypedMess = crypedMess.Insert(index, value);
                }
                else if (type == "Move")
                {
                    int numOfLetters = int.Parse(arr[1]);

                    string cutLett = crypedMess.Remove(numOfLetters);
                    crypedMess = crypedMess.Remove(0, numOfLetters);
                    crypedMess = crypedMess + cutLett;
                }
            }

            Console.WriteLine($"The decrypted message is: {crypedMess}");
        }
    }
}
