using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = arr[0];
                string lastName = arr[1];
                double grade = double.Parse(arr[2]);

                Students currStudent = new Students(firstName, lastName, grade);
                student.Add(currStudent);
            }

            student = student.OrderByDescending(x => x.Grade).ToList();

            foreach (Students printStudents in student)
            {
                Console.WriteLine(printStudents);
            }
        }

        class Students
        {
            public Students(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
            }
        }
    }
}
