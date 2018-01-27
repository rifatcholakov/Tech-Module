using System;
using System.Collections.Generic;
using System.Linq;

namespace JSON_Stringify
{

    public class JSONStringify
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            
            while(input != "stringify")
            {
                string[] inputParts = input.Split(":->, ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Student student = new Student();

                student.Name = inputParts[0];
                student.Age = int.Parse(inputParts[1]);
                student.Grades = inputParts.Skip(2).Select(int.Parse).ToArray();

                students.Add(student);

                input = Console.ReadLine();
            }

            Console.WriteLine("[" +
                string.Join(",", students.Select(student =>
                        $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}")) + 
                        "]");
        }
    }
}
