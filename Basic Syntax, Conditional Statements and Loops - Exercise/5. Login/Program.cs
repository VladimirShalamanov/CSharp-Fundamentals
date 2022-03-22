using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;
            for (int reverceIndex = userName.Length - 1; reverceIndex >= 0; reverceIndex--)
            {
                password += userName[reverceIndex];
            }
            for (int count = 1; count <= 4; count++)
            {
                string enterPassword = Console.ReadLine();

                if (enterPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }
    }
}
