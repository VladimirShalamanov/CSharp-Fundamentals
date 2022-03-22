using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());

            Console.Write($"Name: {name}, Age: {age}, Grade: {average:f2}");
        }
    }
}
