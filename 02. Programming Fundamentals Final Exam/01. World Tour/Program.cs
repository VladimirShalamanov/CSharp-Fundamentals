using System;
using System.Linq;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Travel")
            {
                string[] arr = cmd
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];

                if (type == "Add Stop")
                {
                    int oneIndex = int.Parse(arr[1]);
                    string twoStr = arr[2];
                    if (0 <= oneIndex && oneIndex < destination.Length)
                    {
                        destination = destination.Insert(oneIndex, twoStr);
                    }
                    Console.WriteLine(destination);
                }
                else if (type == "Remove Stop")
                {
                    int oneIndex = int.Parse(arr[1]);
                    int twoIndex = int.Parse(arr[2]);
                    if (0 <= oneIndex && oneIndex < destination.Length && 0 <= twoIndex && twoIndex < destination.Length)
                    {
                        destination = destination.Remove(oneIndex, twoIndex - oneIndex + 1);
                    }
                    Console.WriteLine(destination);
                }
                else if (type == "Switch")
                {
                    string oneStr = arr[1];
                    string twoStr = arr[2];
                    if (destination.Contains(oneStr))
                    {
                        destination = destination.Replace(oneStr, twoStr);
                    }
                    Console.WriteLine(destination);
                }
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destination}");
        }
    }
}
