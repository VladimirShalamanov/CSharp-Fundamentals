using System;
using System.Collections.Generic;

namespace _7._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> namesGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!namesGrades.ContainsKey(name))
                {
                    namesGrades[name] = new List<double>()
                    {
                        grade, 1
                    };
                }
                else if (namesGrades.ContainsKey(name))
                {
                    namesGrades[name][0] += grade;
                    namesGrades[name][1]++;
                }
            }

            foreach (var item in namesGrades)
            {
                string student = item.Key.ToString();
                double newGrade = item.Value[0] / item.Value[1];

                if (newGrade >= 4.50)
                {
                    Console.WriteLine($"{student} -> {newGrade:f2}");
                }
            }
        }
    }
}
