using System;
using System.Collections.Generic;

namespace Filter_Base
{
    public class FilterBase
    {
        public static void Main()
        {
            Dictionary<string, string> positions = new Dictionary<string, string>();
            Dictionary<string, int> ages = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();

            string input = Console.ReadLine();
            input = FilingTheDatabase(positions, ages, salary, input);

            input = Console.ReadLine().ToLower();

            Filter(positions, ages, salary, input);

        }

        public static string FilingTheDatabase(Dictionary<string, string> positions, Dictionary<string, int> ages, Dictionary<string, double> salary, string input)
        {
            while (input != "filter base")
            {
                int age = 0;
                double money = 0;

                string[] tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                if (int.TryParse(tokens[1], out age))
                {
                    ages[name] = age;
                }
                else if (double.TryParse(tokens[1], out money))
                {
                    salary[name] = money;
                }
                else
                {
                    positions[name] = tokens[1];
                }

                input = Console.ReadLine();
            }

            return input;
        }

        public static void Filter(Dictionary<string, string> positions, Dictionary<string, int> ages, Dictionary<string, double> salary, string input)
        {
            switch (input)
            {
                case "salary":

                    foreach (var employee in salary)
                    {
                        Console.WriteLine($"Name: {employee.Key.Trim()}");
                        Console.WriteLine("Salary: {0:F2}", employee.Value);
                        Console.WriteLine("====================");
                    }
                    break;

                case "position":

                    foreach (var employee in positions)
                    {
                        Console.WriteLine($"Name: {employee.Key.Trim()}");
                        Console.WriteLine($"Position: {employee.Value.Trim()}");
                        Console.WriteLine("====================");
                    }
                    break;

                case "age":

                    foreach (var employee in ages)
                    {
                        Console.WriteLine($"Name: {employee.Key.Trim()}");
                        Console.WriteLine($"Age: {employee.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
            }
        }
    }
}
