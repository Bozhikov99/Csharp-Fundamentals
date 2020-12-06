using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int articles = int.Parse(Console.ReadLine());
            List<Article> articlesInput = new List<Article>();
            for (int i = 0; i < articles; i++)
            {
                //Science, planets, Bill
                string[] cmd = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article(cmd[0], cmd[1], cmd[2]);
                articlesInput.Add(article);
            }
            string sortCriteria = Console.ReadLine();
            List<Article> sortedList = new List<Article>();
            if (sortCriteria=="title")
            {
                sortedList = articlesInput
               .OrderBy(articlesInput => articlesInput.Title)
               .ToList();
            }
            else if (sortCriteria == "content")
            {
                sortedList = articlesInput
               .OrderBy(articlesInput => articlesInput.Content)
               .ToList();
            }
            else if (sortCriteria == "author")
            {
                sortedList = articlesInput
               .OrderBy(articlesInput => articlesInput.Author)
               .ToList();
            }
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList[i].ToString());
            }
            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author= author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
