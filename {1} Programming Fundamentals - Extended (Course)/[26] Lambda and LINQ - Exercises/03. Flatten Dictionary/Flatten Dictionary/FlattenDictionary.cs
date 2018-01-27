﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Flatten_Dictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] inputParams = input.Split(' ');

                if (inputParams[0] != "flatten")
                {

                    string key = inputParams[0];
                    string innerKey = inputParams[1];
                    string innverValue = inputParams[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                        dictionary[key][innerKey] = innverValue;
                }
                else
                {
                    string key = inputParams[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            }

            Dictionary<string, Dictionary<string, string>> orderedDictionary = 
            dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine($"{entry.Key}");

                Dictionary<string, string> orderedInnerDictionary =
                    entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                Dictionary<string, string> flattenedValues =
                    entry.Value
                        .Where(x => x.Value == "flattened")
                        .ToDictionary(x => x.Key, x => x.Value);

                int count = 1;

                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");
                    count++;
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine($"{count}. {flattenedEntry.Key}");
                    count++;
                }
            }
        }
    }
}
