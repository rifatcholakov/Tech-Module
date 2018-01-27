using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)    
                .Distinct()
                .OrderBy(w => w)
                .Where(w => w.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
