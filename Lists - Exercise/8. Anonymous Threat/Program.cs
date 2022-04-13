using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(' ')
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arr = command.Split();

                string type = arr[0];
                if (type == "merge")
                {
                    int startIndex = int.Parse(arr[1]);
                    int endIndex = int.Parse(arr[2]);

                    GetMerged(names, startIndex, endIndex);
                }

                else if (type == "divide")
                {
                    int index = int.Parse(arr[1]);
                    int partitions = int.Parse(arr[2]);

                    string name = names[index];
                    if (partitions > name.Length)
                    {
                        return;
                    }

                    int partLength = name.Length / partitions;
                    int partRemind = name.Length % partitions;
                    int lastPartLength = partLength + partRemind;

                    List<string> partitionsList = new List<string>();
                    for (int i = 0; i < partitions; i++)
                    {
                        char[] currPart;
                        if (i == partitions)
                        {
                            currPart = name
                                .Skip(i * partLength)
                                .Take(lastPartLength)
                                .ToArray();
                        }
                        else
                        {
                            currPart = name
                                .Skip(i * partLength)
                                .Take(partLength)
                                .ToArray();
                        }

                        partitionsList.Add(new string (currPart));
                    }

                    names.RemoveAt(index);
                    names.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }

        static void GetMerged(List<string> names, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= names.Count)
            {
                endIndex = names.Count - 1;
            }

            StringBuilder merged = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                merged.Append(names[startIndex]);
                names.RemoveAt(startIndex);
            }

            names.Insert(startIndex, merged.ToString());
        }
    }
}
