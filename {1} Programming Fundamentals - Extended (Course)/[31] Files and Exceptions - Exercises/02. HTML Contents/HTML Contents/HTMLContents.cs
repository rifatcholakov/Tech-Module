using System;
using System.IO;
using System.Text;

namespace HTML_Contents
{
    public class HTMLContents
    {
        public static void Main()
        {
            StringBuilder result = new StringBuilder();

            string title = String.Empty;

            string[] input = File.ReadAllLines("input.txt");

            foreach (var item in input)
            {
                if (item.Equals("exit"))
                {
                    break;
                }

                string[] inputParts = item.Split(' ');

                string tag = inputParts[0];
                string tagContent = inputParts[1];

                if (tag.Equals("title"))
                {
                    title = tagContent;
                }
            }

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");
            result.AppendLine($"\t<title>{title}</title>");
            result.AppendLine("</head>");
            result.AppendLine("<body>");

            foreach (var item in input)
            {
                if (item.Equals("exit"))
                {
                    break;
                }

                string[] inputParts = item.Split(' ');

                string tag = inputParts[0];
                string tagContent = inputParts[1];

                if (tag.Equals("title"))
                {
                    title = tagContent;
                }                
                else
                {
                    result.AppendLine($"\t<{tag}>{tagContent}</{tag}>");
                }
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.AppendAllText("index.html", result.ToString().TrimEnd());
        }
    }
}
