using System;
using System.Linq;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string rawPassword = string.Empty;

            string cmd;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] arr = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = arr[0];
                if (type == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            rawPassword += password[i];
                        }
                    }
                    password = rawPassword;
                    Console.WriteLine(password);
                }
                else if (type == "Cut")
                {
                    int index = int.Parse(arr[1]);
                    int length = int.Parse(arr[2]);
                    password = password.Remove(index, length);

                    Console.WriteLine(password);
                }
                else if (type == "Substitute")
                {
                    string substring = arr[1];
                    string substitute = arr[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
