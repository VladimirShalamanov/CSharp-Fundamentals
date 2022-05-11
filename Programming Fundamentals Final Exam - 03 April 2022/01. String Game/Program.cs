using System;
using System.Linq;

namespace _01._String_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] arr = cmd
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];

                if (type == "Change")
                {
                    char ch = char.Parse(arr[1]);
                    char replace = char.Parse(arr[2]);
                    text = text.Replace(ch, replace);
                    Console.WriteLine(text);
                }
                else if (type == "Includes")
                {
                    string subs = arr[1];
                    if (text.Contains(subs))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (type == "End")
                {
                    string subs = arr[1];
                    string end = text.Substring(text.Length - subs.Length);

                    if (end == subs)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (type == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (type == "FindIndex")
                {
                    char ch = char.Parse(arr[1]);
                    int index = text.IndexOf(ch);
                    Console.WriteLine(index);
                }
                else if (type == "Cut")
                {
                    int start = int.Parse(arr[1]);
                    int count = int.Parse(arr[2]);
                    text = text.Substring(start, count);
                    Console.WriteLine(text);
                }
            }
        }
    }
}
