using System;
using System.Collections.Generic;
using System.Linq;

namespace Default_Values
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string key = tokens[0];
                string value = tokens[1];

                dictionary[key] = value;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            dictionary
                 .Where(x => x.Value != "null")
                 .OrderByDescending(x => x.Value.Length)
                 .ToList()
                 .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, x.Value));

            dictionary
                .Where(x => x.Value == "null")
                .Select(x => x.Key + " <-> " + input)
                .ToList()
                .ForEach(Console.WriteLine);             
        }
    }
}
