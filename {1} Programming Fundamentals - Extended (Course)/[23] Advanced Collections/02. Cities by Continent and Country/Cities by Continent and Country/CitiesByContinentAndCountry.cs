using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    public  class CitiesByContinentAndCountry
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, List<string>>> continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (var continent in continentsData)
            {
                Console.WriteLine(continent.Key + ":");

                foreach (var country in continent.Value)
                {
                    Console.Write("  " + country.Key + " -> ");

                        Console.Write(string.Join(", ", country.Value));

                    Console.WriteLine();
                }

            }

        }
    }
}
