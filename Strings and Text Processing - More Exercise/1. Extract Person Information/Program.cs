using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string sentence = Console.ReadLine();

                int nameStart = sentence.IndexOf('@');
                int nameEnd = sentence.IndexOf('|');
                string namePerson = sentence.Substring(nameStart + 1, nameEnd - nameStart - 1);

                int ageStart = sentence.IndexOf('#');
                int ageEnd = sentence.IndexOf('*');
                string agePerson = sentence.Substring(ageStart + 1, ageEnd - ageStart - 1);

                Console.WriteLine($"{namePerson} is {agePerson} years old.");
            }
        }
    }
}
