using System;
using System.Collections.Generic;


namespace Mixed_Phones
{
    public class MixedPhones
    {
        public static void Main()
        {
            SortedDictionary<string, long> phoneBook = new SortedDictionary<string, long>();

            string input = Console.ReadLine();

            while (input != "Over")
            {
                string[] tokens = input.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string firstElement = tokens[0];
                string secondElement = tokens[1];

                long phoneNumber = 0;

                if (long.TryParse(firstElement, out phoneNumber))
                {
                    phoneBook[secondElement] = phoneNumber;
                }
                else
                {
                    phoneNumber = long.Parse(secondElement);
                    phoneBook[firstElement] = phoneNumber;
                }

                input = Console.ReadLine();
            }

            foreach (var item in phoneBook)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
