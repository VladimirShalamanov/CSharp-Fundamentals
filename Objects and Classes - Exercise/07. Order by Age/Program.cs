using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        class Peoples
        {
            public Peoples(string name, string id, int age)
            {
                this.Name = name;
                this.Id = id;
                this.Age = age;
            }
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }
        
        static void Main(string[] args)
        {
            List<Peoples> people = new List<Peoples>();

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string[] arr = cmd.Split(' ').ToArray();
                string name = arr[0];
                string id = arr[1];
                int age = int.Parse(arr[2]);

                Peoples current = new Peoples(name, id, age);
                current.Name = name;
                current.Id = id;
                current.Age = age;
                int currIndex = people.FindIndex(x => x.Id == id);

                if (currIndex == -1)
                {
                    people.Add(current);
                }
                else
                {
                    people[currIndex] = current;
                }
            }

            List<Peoples> ordered = people.OrderBy(x => x.Age).ToList();
            foreach (Peoples item in ordered)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
}
