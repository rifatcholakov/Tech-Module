using System;

namespace String_Repeater
{
    public class StringRepeater
    {
        public static void Main()
        {
            string repeatedString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(repeatedString, count);
        }
        public static void RepeatString(string repeatedString, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(repeatedString);
            }
        }
    }
}
