using System;

namespace Animals
{
    public class Dog
    {
        public string name { get; set; }

        public int age { get; set; }

        public int numberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }

        public static Dog Parse(string input)
        {
            string[] inputParts = input.Split(' ');

            return new Dog
            {
                name = inputParts[1],
                age = int.Parse(inputParts[2]),
                numberOfLegs = int.Parse(inputParts[3])
            };
        }
    }
}
