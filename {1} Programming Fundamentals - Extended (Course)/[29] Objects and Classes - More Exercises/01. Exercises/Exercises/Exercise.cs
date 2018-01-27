using System;

namespace Exercises
{
    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public string[] Problems { get; set; }

        public static Exercise Parse(string input)
        {
            string[] exerciseParts = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new Exercise
            {
                Topic = exerciseParts[0],
                CourseName = exerciseParts[1],
                JudgeContestLink = exerciseParts[2],
                Problems = exerciseParts[3].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            };
        }
    }
}

