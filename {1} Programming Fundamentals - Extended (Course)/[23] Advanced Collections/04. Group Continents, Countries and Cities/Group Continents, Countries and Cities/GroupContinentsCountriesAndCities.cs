using System;
using System.Collections.Generic;

namespace Group_Continents__Countries_and_Cities
{
    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> continetsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continetsData.ContainsKey(continent))
                {
                    continetsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!continetsData[continent].ContainsKey(country))
                {
                    continetsData[continent][country] = new SortedSet<string>();
                }

                continetsData[continent][country].Add(city);
            }

            foreach (var continent in continetsData)
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
