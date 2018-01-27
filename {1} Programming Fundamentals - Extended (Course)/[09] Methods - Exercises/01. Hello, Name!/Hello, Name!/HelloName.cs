using System;

namespace Hello__Name_
{
    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
        }
        public static void Name(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
