using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> arts = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string title = arr[0];
                string content = arr[1];
                string author = arr[2];

                Article currArt = new Article(title, content, author);

                arts.Add(currArt);
            }

            string criteria = Console.ReadLine();

            if (criteria == "title")
            {
                arts = arts.OrderBy(a => a.Title).ToList();
            }
            else if (criteria == "content")
            {
                arts = arts.OrderBy(a => a.Content).ToList();
            }
            else if (criteria == "author")
            {
                arts = arts.OrderBy(a => a.Author).ToList();
            }

            foreach (Article article in arts)
            {
                Console.WriteLine(article);
            }
        }

        public class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public object Title { get; set; }

            public object Content { get; set; }

            public object Author { get; set; }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
