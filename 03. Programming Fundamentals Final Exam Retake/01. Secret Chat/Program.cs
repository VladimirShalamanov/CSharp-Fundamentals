using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] arr = cmd
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                
                if (type == "InsertSpace")
                {
                    int index = int.Parse(arr[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (type == "Reverse")
                {
                    string substring = arr[1];

                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);
                        message = message.Remove(index, substring.Length);
                        char[] charArr = substring.ToCharArray();
                        Array.Reverse(charArr);
                        var builder = new StringBuilder();
                        builder.Append(message);
                        builder.Append(charArr);
                        message = builder.ToString();
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (type == "ChangeAll")
                {
                    string substr = arr[1];
                    string replacement = arr[2];
                    message = message.Replace(substr, replacement);
                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
