using System;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(' ');

            string[] names = Console.ReadLine()
                .Split(' ');

            while (true)
            {
                int i = 0;

                string search = Console.ReadLine();

                for (int j = 0; j < names.Length; j++)
                {

                    if (search.Equals("done"))
                    {
                        return;
                    }

                    if (Array.Equals(names[j], search))
                    {
                        Console.WriteLine(names[j] + " -> " + numbers[j]);
                    }

                }

                i++;
            }

        }
    }
}
