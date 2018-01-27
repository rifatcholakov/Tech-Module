using System;
using System.Collections.Generic;

namespace JSON_Parse
{

    public class JSONParse
    {
        public static void Main()
        {           
            string input = Console.ReadLine();

            List<Student> studentsList = new List<Student>();

            List<string> studentPartsList = SplitByCurlyBtackets(input);

            string[] studentParts = studentPartsList.ToArray();



            foreach (var property in studentParts)
            {
                string[] name, age, grades;
                SplitStudentParts(property, out name, out age, out grades);

                Student student = new Student()
                {
                    Name = name[1],
                    Age = int.Parse(age[0]),
                    Grades = grades
                };

                studentsList.Add(student);
            }

            Output(studentsList);
        }

        private static void Output(List<Student> studentsList)
        {
            foreach (var person in studentsList)
            {
                if (person.Grades.Length == 0)
                {
                    Console.WriteLine($"{person.Name} : {person.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{person.Name} : {person.Age} -> {string.Join(", ", person.Grades)}");
                }
            }
        }

        private static void SplitStudentParts(string property, out string[] name, out string[] age, out string[] grades)
        {
            string[] propertyParts = property.Split(':');

            name = propertyParts[1].Split("\"\\,".ToCharArray());
            age = propertyParts[2].Split(',');
            grades = propertyParts[3].Split("[], ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        }

        private static List<string> SplitByCurlyBtackets(string input)
        {
            string[] inputParts = input.Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> studentPartsList = new List<string>();

            for (int i = 0; i < inputParts.Length; i++)
            {
                if (inputParts[i] != "," && inputParts[i] != "[" && inputParts[i] != "]")
                {
                    studentPartsList.Add(inputParts[i]);
                }
            }

            return studentPartsList;
        }
    }
}
