using System;
using System.Collections.Generic;
using System.Linq;

namespace CottageScraper
{
    public class CottageScraper
    {
        public static void Main()
        {
            Dictionary<string, List<int>> logCollection = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while(input != "chop chop")
            {
                string[] tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string treeType = tokens[0];
                int treeHeight = int.Parse(tokens[1]);

                if (!logCollection.ContainsKey(treeType))
                {
                    logCollection[treeType] = new List<int>();
                }
                
                logCollection[treeType].Add(treeHeight);

                input = Console.ReadLine(); 
            }

            string typeOfTree = Console.ReadLine();

            int minimumLenghtPerTree = int.Parse(Console.ReadLine());

            int logsSum = logCollection.Sum(x => x.Value.Sum());
            int logsCount = logCollection.Values.Sum(x => x.Count);

            double pricePerMeter = Math.Round((double)logsSum / logsCount, 2);

            var filteredUsedLogs = logCollection
                .Where(x => x.Key.Equals(typeOfTree))
                .SelectMany(x => x.Value.Where(y => y >= minimumLenghtPerTree)
                .ToList());

            double usedLogsPrice = Math.Round(filteredUsedLogs.Sum() * pricePerMeter, 2);
            double unusedLogs = (logCollection.Sum(x => x.Value.Sum()) - filteredUsedLogs.Sum());
            double unusedLogsPrice = Math.Round(unusedLogs * pricePerMeter * 0.25, 2);
            double cottageScraperSubTotal = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubTotal:f2}");
        }
    }
}
