using System;
using System.Collections.Generic;

namespace Websites
{

    public class Websites
    {
        public static void Main()
        {
            List<string> websitesList = new List<string>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string[] inputParts = input.Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Website website = new Website();

                website.host = inputParts[0];
                website.domain = inputParts[1];

                string link = string.Empty;

                if (inputParts.Length > 2)
                {
                    string queries = JoinQueries(inputParts, website);

                    link = "https://www." + website.host + "." + website.domain + "/query?=" + queries;
                }
                else
                {
                    link = "https://www." + website.host + "." + website.domain;
                }

                websitesList.Add(link);

                input = Console.ReadLine();
            }

            Output(websitesList);
        }

        public static string JoinQueries(string[] inputParts, Website website)
        {
            website.queries = inputParts[2].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < website.queries.Length; i++)
            {
                website.queries[i] = "[" + website.queries[i] + "]";
            }

            string queries = String.Join("&", website.queries);
            return queries;
        }

        public static void Output(List<string> websitesList)
        {
            foreach (var link in websitesList)
            {
                Console.WriteLine(link);
            }
        }
    }
}
