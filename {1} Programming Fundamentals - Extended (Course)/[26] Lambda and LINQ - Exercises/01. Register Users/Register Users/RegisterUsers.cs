using System;
using System.Collections.Generic;
using System.Linq;

namespace Register_Users
{
    class RegisterUsers
    {
        static void Main()
        {
            Dictionary<string, DateTime> database = new Dictionary<string, DateTime>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] tokens = input
                    .Split(new char[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string user = tokens[0];
                string date = tokens[1];

                database[user] = DateTime.ParseExact(date, "dd/MM/yyyy", null); ;

                input = Console.ReadLine();
            }

            var result = database
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value);


            foreach (var user in result)
            {
                Console.WriteLine(user.Key);
            }
        }
    }
}
