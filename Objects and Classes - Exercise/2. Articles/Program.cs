using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Article article = new Article(articles[0], articles[1], articles[2]);

            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = arr[0];
                string newData = arr[1];

                if (type == "Edit")
                {
                    article.Edit(newData);
                }
                else if (type == "ChangeAuthor")
                {
                    article.ChangeAuthor(newData);
                }
                else if (type == "Rename")
                {
                    article.Rename(newData);
                }
            }

            Console.WriteLine(article.ToString());
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

            public void Edit(string newContent)
            {
                this.Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }

            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}
