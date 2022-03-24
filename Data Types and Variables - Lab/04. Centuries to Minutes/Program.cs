using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int yearsInCenturies = 100;
            const decimal daysInYear = 365.2422m;
            const int hoursInDay = 24;
            const int minutesInHour = 60;

            var centuries = int.Parse(Console.ReadLine());
            int years = centuries * yearsInCenturies;
            int days = (int)(years * daysInYear);
            int hours = days * hoursInDay;
            int minutes = hours * minutesInHour;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
