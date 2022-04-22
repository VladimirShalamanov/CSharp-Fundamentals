using System;

namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
            string[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            int n = int.Parse(Console.ReadLine());

            Random phrases1 = new Random();
            Random events1 = new Random();
            Random authors1 = new Random();
            Random cities1 = new Random();

            for (int i = 1; i <= n; i++)
            {
                int phrasesIndex = phrases1.Next(0,phrases.Length);
                int eventsIndex = events1.Next(0, events.Length);
                int authorsIndex = authors1.Next(0, authors.Length);
                int citiesIndex = cities1.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phrasesIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}");
            }
        }
    }
}
