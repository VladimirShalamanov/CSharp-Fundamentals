using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();

            string resourse;
            while ((resourse = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resourse))
                {
                    mine.Add(resourse, 0);
                }

                mine[resourse] += quantity;
            }

            foreach(var print in mine)
            {
                Console.WriteLine($"{print.Key} -> {print.Value}");
            }
        }
    }
}
