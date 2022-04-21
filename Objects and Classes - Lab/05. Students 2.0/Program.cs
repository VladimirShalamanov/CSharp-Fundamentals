using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] arr = cmd.Split();

                string firstName = arr[0];
                string lastName = arr[1];
                int age = int.Parse(arr[2]);
                string city = arr[3];

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.City = city;
                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };

                    students.Add(student);
                }
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existStudent = student;
                }
            }

            return existStudent;
        }

        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
    }
}
