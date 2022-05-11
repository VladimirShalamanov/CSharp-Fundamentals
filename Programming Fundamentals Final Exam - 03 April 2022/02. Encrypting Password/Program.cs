using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"([^ ]+)\>(?<digit>[0-9]{3})\|(?<low>[a-z]{3})\|(?<up>[A-Z]{3})\|(?<char>([^\<\>]{3}))\<(\1)");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);
                string password = string.Empty;
                if (match.Success)
                {
                    string digit = match.Groups["digit"].Value;
                    string low = match.Groups["low"].Value;
                    string up = match.Groups["up"].Value;
                    string ch = match.Groups["char"].Value;
                    password = digit + low + up + ch;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
