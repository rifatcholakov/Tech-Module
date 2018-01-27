using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    public class AverageStudentGrades
    {
        public static void Main()
        {
            Dictionary<string, List<double>> studentsBook = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                string name = tokens[0];
                double grade = double.Parse(tokens[1]);

                if (!studentsBook.ContainsKey(name))
                {
                    studentsBook[name] = new List<double>();
                    studentsBook[name].Add(grade);
                } else
                {
                    studentsBook[name].Add(grade);
                }
        
            }

            foreach (var student in studentsBook)
            {
                string name = student.Key;
                List<double> studentGrades = student.Value;

                double average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:F2} ");
                }
                
                Console.Write($"(avg: {average:F2}) ");

                Console.WriteLine();
            }
        }
    }
}
