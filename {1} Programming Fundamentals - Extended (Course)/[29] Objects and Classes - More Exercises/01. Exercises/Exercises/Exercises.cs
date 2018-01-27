using System;
using System.Collections.Generic;

namespace Exercises
{

    public class Exercises
    {
        public static void Main()
        {
            List<Exercise> list = new List<Exercise>();

            string input = Console.ReadLine();

            while (input != "go go go")
            {
                Exercise currentInput = Exercise.Parse(input);

                list.Add(currentInput);

                input = Console.ReadLine();
            } 

            foreach (var item in list)
            {
                int count = 1;

                Console.WriteLine("Exercises: " + item.Topic.Trim());
                Console.WriteLine("Problems for exercises and homework for the \"" + item.CourseName.Trim() + "\" course @ SoftUni.");
                Console.WriteLine("Check your solutions here: " + item.JudgeContestLink.Trim());

                foreach (var problem in item.Problems)
                {
                    Console.WriteLine(count + ". " + problem);
                    count++;
                }
            }
        }
    }
}
