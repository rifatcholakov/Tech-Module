using System;
using System.Collections.Generic;

namespace User_Logins
{
    public class UserLogins
    {
        public static void Main()
        {
            Dictionary<string, string> database = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "login")
            {
                string[] tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string username = tokens[0];
                string password = tokens[1];

                database[username] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            int failedAttempts = 0;

            while (input != "end")
            {
                

                string[] tokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string username = tokens[0];
                string password = tokens[1];

                if(database.ContainsKey(username) && database[username] == password)
                {
                    Console.WriteLine($"{username.TrimEnd()}: logged in successfully");
                }
                else
                {
                    failedAttempts++;

                    Console.WriteLine($"{username.TrimEnd()}: login failed");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {failedAttempts}");
        }
    }
}
