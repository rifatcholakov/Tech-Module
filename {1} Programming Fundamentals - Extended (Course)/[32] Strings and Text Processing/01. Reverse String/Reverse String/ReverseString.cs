using System;
using System.Linq;

namespace Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string output = new string(input.ToCharArray().Reverse().ToArray());

            Console.WriteLine(output);
        }
    }
}
