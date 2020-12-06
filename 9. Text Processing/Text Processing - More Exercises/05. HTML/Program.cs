using System;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string headline = Console.ReadLine();
            sb.AppendLine("<h1>");
            sb.AppendLine($"    {headline}");
            sb.AppendLine("</h1>");
            string content = Console.ReadLine();
            sb.AppendLine("<article>");
            sb.AppendLine($"    {content}");
            sb.AppendLine("</article>");
            string cmd = Console.ReadLine();
            while (cmd!="end of comments")
            {
                sb.AppendLine("<div>");
                sb.AppendLine($"    {cmd}");
                sb.AppendLine("</div>");
                cmd = Console.ReadLine();
            }
            Console.WriteLine(sb);
        }
    }
}
