using System;

namespace _3._Vacationv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;

            if (dayOfWeek == "Friday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.90; break;
                    case "Regular": price = 15.00; break;
                }
            }
            if (dayOfWeek == "Saturday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 9.80; break;
                    case "Business": price = 15.60; break;
                    case "Regular": price = 20.00; break;
                }
            }
            if (dayOfWeek == "Sunday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16.00; break;
                    case "Regular": price = 22.50; break;
                }
            }
            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                price = price - (price * 0.15);
            }
            else if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                countOfPeople -= 10;
            }
            else if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                price = price - (price * 0.05);
            }
            Console.WriteLine($"Total price: {price * countOfPeople:F2}");
        }
    }
}
