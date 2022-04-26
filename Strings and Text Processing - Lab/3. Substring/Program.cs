using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string set = Console.ReadLine();
            string work = Console.ReadLine();

            while (work.Contains(set))
            {
                work = work.Replace(set, "");
            }

            Console.WriteLine(work);
        }
    }
}
