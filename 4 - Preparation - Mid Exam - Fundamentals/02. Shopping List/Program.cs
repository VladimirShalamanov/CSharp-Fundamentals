using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listGroceries = Console.ReadLine()
                .Split('!')
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] grocery = command.Split(' ').ToArray();
                string type = grocery[0];
                string product = grocery[1];

                if (type == "Urgent")
                {
                    if (product == listGroceries.Find(x => x == product))
                    {
                        continue;
                    }
                    listGroceries.Insert(0, product);
                }
                else if (type == "Unnecessary")
                {
                    if (product != listGroceries.Find(x => x == product))
                    {
                        continue;
                    }
                    listGroceries.Remove(product);
                }
                else if (type == "Correct")
                {
                    if (product != listGroceries.Find(x => x == product))
                    {
                        continue;
                    }
                    string newProduct = grocery[2];
                    int index = listGroceries.IndexOf(product);
                    listGroceries.Remove(product);
                    listGroceries.Insert(index, newProduct);
                }
                else if (type == "Rearrange")
                {
                    if (product != listGroceries.Find(x => x == product))
                    {
                        continue;
                    }
                    listGroceries.Remove(product);
                    listGroceries.Add(product);
                }
            }

            Console.WriteLine(string.Join(", ", listGroceries));
        }
    }
}
