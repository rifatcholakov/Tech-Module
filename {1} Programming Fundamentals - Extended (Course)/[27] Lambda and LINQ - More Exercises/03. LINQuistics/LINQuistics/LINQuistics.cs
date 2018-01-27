using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            Dictionary<string, List<string>> collectionsInformation = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            string collection = String.Empty;

            while (!inputLine.Equals("exit"))
            {
                string[] inputParams = inputLine
                    .Split(".() ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                collection = inputParams[0];
                int count = 0;

                if (inputParams.Count() > 1)
                {
                    AddCollections(collectionsInformation, collection, inputParams);
                }
                else if (collectionsInformation.ContainsKey(collection))
                {
                    PrintCollectionMethods(collectionsInformation, collection);
                }
                else if (int.TryParse(inputParams[0], out count) && collectionsInformation.Count > 0)
                {
                    PrintNMethods(collectionsInformation, count);
                }

                inputLine = Console.ReadLine();
            }

            string[] finalInput = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string method = finalInput[0];

            Dictionary<string, List<string>> result = OrderedCollectionInformation(collectionsInformation, method);

            string selection = finalInput[1];

            if (selection.Equals("all"))
            {
                PrintAll(result);
            }

            else if (selection.Equals("collection"))
            {
                PrintOnlyCollections(result);
            }
        }

        public static void AddCollections(Dictionary<string, List<string>> result, string collection, string[] input)
        {
            if (!result.ContainsKey(collection))
            {
                result[collection] = new List<string>();
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (!result[collection].Contains(input[i]))
                {
                    result[collection].Add(input[i]);
                }
            }
        }

        public static Dictionary<string, List<string>> OrderedCollectionInformation(Dictionary<string, List<string>> result, string method)
        {
            return result
                    .Where(y => y.Value.Contains(method))
                    .OrderByDescending(y => y.Value.Count)
                    .ThenByDescending(y => y.Value.Min(z => z.Length))
                    .ToDictionary(x => x.Key, x => x.Value);
        }

        public static void PrintOnlyCollections(Dictionary<string, List<string>> finalResult)
        {
            foreach (var key in finalResult.Keys)
            {
                Console.WriteLine(key);
            }
        }

        public static void PrintAll(Dictionary<string, List<string>> finalResult)
        {
            foreach (var key in finalResult)
            {
                Console.WriteLine(key.Key);

                foreach (var item in finalResult[key.Key].OrderByDescending(x => x.Count()))
                {
                    Console.WriteLine("* {0}", item);
                }
            }
        }

        public static void PrintNMethods(Dictionary<string, List<string>> result, int count)
        {
            List<string> printNMethods = result.Values
                                    .OrderByDescending(x => x.Count).First()
                                    .OrderBy(x => x.Length)
                                    .Take(count)
                                    .ToList();

            foreach (var item in printNMethods)
            {
                Console.WriteLine("* {0}", item);
            }
        }

        public static void PrintCollectionMethods(Dictionary<string, List<string>> result, string collection)
        {
            List<string> resultForPrinting = result[collection]
                                    .OrderByDescending(x => x.Length)
                                    .ThenByDescending(x => x.Distinct().Count())
                                    .ToList();

            foreach (var values in resultForPrinting)
            {
                Console.WriteLine("* {0}", values);
            }            
        }
    }
}
