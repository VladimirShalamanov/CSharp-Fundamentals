using System;

namespace _1._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int agePerson = int.Parse(Console.ReadLine());

            string word = string.Empty;
            if (0 <= agePerson && agePerson <= 2)
            {
                word = "baby";
            }
            else if (3 <= agePerson && agePerson <= 13)
            {
                word = "child";
            }
            else if (14 <= agePerson && agePerson <= 19)
            {
                word = "teenager";
            }
            else if (20 <= agePerson && agePerson <= 65)
            {
                word = "adult";
            }
            else if (agePerson >= 66)
            {
                word = "elder";
            }

            Console.WriteLine(word);
        }
    }
}
