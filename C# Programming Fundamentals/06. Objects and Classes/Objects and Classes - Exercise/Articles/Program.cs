using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries);
            
            Article x = new Article();
            x.Title =article[0];
            x.Content =article[1];
            x.Author =article[2];

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split(": ",StringSplitOptions.RemoveEmptyEntries);
                //Edit: better content
                switch (cmd[0])
                {
                    case "Edit":
                        Article.Edit(x, cmd[1]);
                        break;
                    case "ChangeAuthor":
                        Article.ChangeAuthor(x, cmd[1]);
                        break;
                    case "Rename":
                        Article.Rename(x, cmd[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(x.ToString());
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public static Article Edit(Article currentArt, string newContent)
        {
            currentArt.Content = newContent;
            return currentArt;
        }
        public static Article ChangeAuthor(Article currentArt, string newAuthor)
        {
            currentArt.Author = newAuthor;
            return currentArt;
        }
        public static Article Rename(Article currentArt, string newName)
        {
            currentArt.Title = newName;
            return currentArt;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
