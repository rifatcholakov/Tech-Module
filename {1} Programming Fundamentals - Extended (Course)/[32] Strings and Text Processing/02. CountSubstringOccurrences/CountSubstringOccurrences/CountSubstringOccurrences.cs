using System;

namespace CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();

            string pattern = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(pattern);

            while(index != -1)
            {
                count++;

                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
