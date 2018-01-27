using System;

namespace Animals
{
    public class Snake
    {
        public string name { get; set; }

        public int age { get; set; }

        public int crueltyCoefficient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

        public static Snake Parse(string input)
        {
            string[] inputParts = input.Split(' ');

            return new Snake
            {
                name = inputParts[1],
                age = int.Parse(inputParts[2]),
                crueltyCoefficient = int.Parse(inputParts[3])
            };
        }
    }
}
