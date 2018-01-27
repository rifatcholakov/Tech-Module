using System;

namespace TrickyStrings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {             
                string input = Console.ReadLine();
                if (i == number-1)
                {
                    Console.Write(input);
                } else
                {
                    Console.Write(input);
                    Console.Write(delimiter);
                }
            }
        }
    }
}
