using System;
using System.Collections.Generic;

namespace Animals
{

    public class Animals
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<int, int>> dogs = new Dictionary<string, Dictionary<int, int>>();
            Dictionary<string, Dictionary<int, int>> cats = new Dictionary<string, Dictionary<int, int>>();
            Dictionary<string, Dictionary<int, int>> snakes = new Dictionary<string, Dictionary<int, int>>();

            string input = Console.ReadLine();

            while (!input.Equals("I'm your Huckleberry"))
            {
                string[] inputParts = input.Split(' ');

                if (inputParts[0].Equals("talk"))
                {
                    if (dogs.ContainsKey(inputParts[1]))
                    {
                        Dog.ProduceSound();
                    }
                    else if (cats.ContainsKey(inputParts[1]))
                    {
                        Cat.ProduceSound();
                    }
                    else if (snakes.ContainsKey(inputParts[1]))
                    {
                        Snake.ProduceSound();
                    }
                }
                else
                {
                    switch (inputParts[0])
                    {
                        case "Dog":
                            Dog dog = Dog.Parse(input);
                            dogs[dog.name] = new Dictionary<int, int>();
                            dogs[dog.name][dog.age] = dog.numberOfLegs;
                            break;

                        case "Cat":
                            Cat cat = Cat.Parse(input);
                            cats[cat.name] = new Dictionary<int, int>();
                            cats[cat.name][cat.age] = cat.intelligenceQuotient;
                            break;

                        case "Snake":
                            Snake snake = Snake.Parse(input);
                            snakes[snake.name] = new Dictionary<int, int>();
                            snakes[snake.name][snake.age] = snake.crueltyCoefficient;
                            break;
                    }
                }

                input = Console.ReadLine();
            }

            DogsOutput(dogs);

            CatsOutput(cats);

            SnakesOutput(snakes);
        }

        public static void DogsOutput(Dictionary<string, Dictionary<int, int>> dogs)
        {
            foreach (var dog in dogs)
            {
                foreach (var item in dog.Value)
                {
                    Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", dog.Key, item.Key, item.Value);
                }
            }
        }

        public static void CatsOutput(Dictionary<string, Dictionary<int, int>> cats)
        {
            foreach (var cat in cats)
            {
                foreach (var item in cat.Value)
                {
                    Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", cat.Key, item.Key, item.Value);
                }
            }
        }

        public static void SnakesOutput(Dictionary<string, Dictionary<int, int>> snakes)
        {
            foreach (var snake in snakes)
            {
                foreach (var item in snake.Value)
                {
                    Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", snake.Key, item.Key, item.Value);
                }
            }
        }
    }
}
