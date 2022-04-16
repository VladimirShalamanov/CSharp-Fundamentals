using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeAnswerHour1 = int.Parse(Console.ReadLine());
            int employeeAnswerHour2 = int.Parse(Console.ReadLine());
            int employeeAnswerHour3 = int.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());

            int totalAnswerPerHour = employeeAnswerHour1 + employeeAnswerHour2 + employeeAnswerHour3;


            int timeNeeded = 0;
            while (studentCount > 0)
            {
                timeNeeded++;
                if (timeNeeded % 4 == 0)
                {
                    continue;
                }
                studentCount -= totalAnswerPerHour;
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
