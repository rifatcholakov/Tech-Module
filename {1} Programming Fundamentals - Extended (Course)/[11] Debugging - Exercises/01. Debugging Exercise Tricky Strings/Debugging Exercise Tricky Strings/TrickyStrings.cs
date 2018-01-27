using System;

namespace Debugging_Exercise_Tricky_Strings
{
    public class TrickyStrings
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 0; i < numberOfStrings; i++)
            {
                if (i == numberOfStrings - 1)
                {
                    currentString = Console.ReadLine();
                    result += currentString;
                } else
                { 
                currentString = Console.ReadLine();
                result += currentString + delimiter;
                }
            }
            Console.WriteLine(result);
        }
    }
}
