using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> info = new Dictionary<string, List<string>>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] arr = cmd
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!info.ContainsKey(arr[0]))
                {
                    info[arr[0]] = new List<string>() { arr[1] };
                }
                else if (info.ContainsKey(arr[0]))
                {
                    info[arr[0]].Add(arr[1]);
                }
            }

            foreach (var course in info)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var item in course.Value)
                {
                    Console.WriteLine($"-- {item}");
                }  
            }
        }
    }
}
