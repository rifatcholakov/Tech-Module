using System;

namespace Triples_of_Latin_Letters
{
    public class TriplesOfLatinLetters
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                for (int j = 0; j < number; j++)
                {

                    for (int k = 0; k < number; k++)
                    {
                        char firstLetter = (char)('a' + i);
                        char secondLetter = (char)('a' + j);
                        char thirdLetter = (char)('a' + k);

                        Console.Write(firstLetter);
                        Console.Write(secondLetter);
                        Console.Write(thirdLetter);

                        Console.WriteLine();
                    }

                }

            }

        }
    }
}
