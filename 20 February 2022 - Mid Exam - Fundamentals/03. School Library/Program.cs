using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Done")
            {
                string[] arr = cmd
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = arr[0];

                if (type == "Add Book")
                {
                    string bookName = arr[1];
                    if (books.Find(x => x == bookName) != bookName)
                    {
                        books.Insert(0, bookName);
                    }
                    continue;
                }
                else if (type == "Take Book")
                {
                    string bookName = arr[1];
                    if (books.Find(x => x == bookName) == bookName)
                    {
                        books.Remove(bookName);
                    }
                    continue;

                }
                else if (type == "Swap Books")
                {
                    string bookName1 = arr[1];
                    string bookName2 = arr[2];
                    if (books.Find(x => x == bookName1) == bookName1 && books.Find(x => x == bookName2) == bookName2)
                    {
                        int index1 = books.IndexOf(bookName1);
                        int index2 = books.IndexOf(bookName2);
                        books.RemoveAt(index1);
                        books.Insert(index1, bookName2);
                        books.RemoveAt(index2);
                        books.Insert(index2, bookName1);
                    }
                    continue;

                }
                else if (type == "Insert Book")
                {
                    string bookName = arr[1];
                    if (books.Find(x => x == bookName) != bookName)
                    {
                        books.Add(bookName);
                    }
                    continue;

                }
                else if (type == "Check Book")
                {
                    int index = int.Parse(arr[1]);
                    if (index >= 0 && index < books.Count)
                    {
                        Console.WriteLine(books[index]);
                    }
                    continue;

                }
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
