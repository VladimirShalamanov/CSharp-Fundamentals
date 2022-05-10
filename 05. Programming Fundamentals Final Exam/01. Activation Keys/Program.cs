using System;
using System.Linq;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Generate")
            {
                string[] arr = cmd
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];

                if (type == "Contains")
                {
                    string substring = arr[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (type == "Flip")
                {
                    string upOrLow = arr[1];
                    int startIndex = int.Parse(arr[2]);
                    int endIndex = int.Parse(arr[3]);

                    if (upOrLow == "Upper")
                    {
                        string keyUp = string.Empty;

                        keyUp = activationKey.Substring(startIndex, endIndex - startIndex);
                        keyUp = keyUp.ToUpper();
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Insert(startIndex, keyUp);

                        Console.WriteLine(activationKey);
                    }
                    else if (upOrLow == "Lower")
                    {
                        string keyLow = string.Empty;

                        keyLow = activationKey.Substring(startIndex, endIndex - startIndex);
                        keyLow = keyLow.ToLower();
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                        activationKey = activationKey.Insert(startIndex, keyLow);

                        Console.WriteLine(activationKey);
                    }
                }
                else if (type == "Slice")
                {
                    int startIndex = int.Parse(arr[1]);
                    int endIndex = int.Parse(arr[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
