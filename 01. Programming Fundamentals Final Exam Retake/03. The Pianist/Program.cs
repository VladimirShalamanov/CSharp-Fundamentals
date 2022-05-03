using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> bookshelf = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string piece = arr[0];
                string composer = arr[1];
                string key = arr[2];

                bookshelf[piece] = new List<string> { composer, key };
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] arr = cmd
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];

                if (type == "Add")
                {
                    string piece = arr[1];
                    string composer = arr[2];
                    string key = arr[3];
                    if (bookshelf.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                        continue;
                    }

                    bookshelf[piece] = new List<string> { composer, key };

                    Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                }
                else if (type == "Remove")
                {
                    string piece = arr[1];
                    if (bookshelf.ContainsKey(piece))
                    {
                        bookshelf.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                        continue;
                    }

                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
                else if (type == "ChangeKey")
                {
                    string piece = arr[1];
                    string key = arr[2];

                    if (bookshelf.ContainsKey(piece))
                    {
                        bookshelf[piece][1] = key;
                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                        continue;
                    }

                    Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                }
            }

            foreach (var item in bookshelf)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
