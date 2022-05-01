using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(names);

            foreach (Match item in match)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
