using System;

namespace Animals
{
    public class Cat
    {
        public string name { get; set; }

        public int age { get; set; }

        public int intelligenceQuotient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }

        public static Cat Parse(string input)
        {
            string[] inputParts = input.Split(' ');

            return new Cat
            {
                name = inputParts[1],
                age = int.Parse(inputParts[2]),
                intelligenceQuotient = int.Parse(inputParts[3])
            };
        }
    }
}
