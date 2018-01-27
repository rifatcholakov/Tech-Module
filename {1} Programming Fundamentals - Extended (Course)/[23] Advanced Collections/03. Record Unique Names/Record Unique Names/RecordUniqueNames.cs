using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    public class RecordUniqueNames
    {
        public static void Main()
        {
            HashSet<string> set = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                set.Add(input);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
