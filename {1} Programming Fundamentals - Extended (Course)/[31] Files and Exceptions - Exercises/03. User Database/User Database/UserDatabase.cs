using System;
using System.Collections.Generic;
using System.IO;

namespace User_Database
{
    public class UserDatabase
    {
        private static string dbPath = "users.txt";
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private static string loggedInUser = null;

        public static void Main()
        {
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Close();
            }

            string[] dbLines = File.ReadAllLines(dbPath);

            foreach (var line in dbLines)
            {
                string[] lineParts = line.Split(' ');

                string username = lineParts[0];
                string password = lineParts[1];

                users[username] = password;
            }                    

            string[] commands = File.ReadAllLines("input.txt");

            foreach (var command in commands)
            {
                string[] commandParts = command.Split(' ');

                switch (commandParts[0])
                {
                    case "register":
                        string username = commandParts[1];
                        string password = commandParts[2];
                        string confirmPassword = commandParts[3];

                        Register(username, password, confirmPassword);
                        break;

                    case "login":
                        username = commandParts[1];
                        password = commandParts[2];

                        Login(username, password);
                        break;

                    case "logout":
                        Logout();
                        break;
                }
            }
        }

        private static void Logout()
        {
            if(loggedInUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }

            loggedInUser = null;
        }

        private static void Login(string username, string password)
        {
            if (loggedInUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }

            if(users[username] != password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }

            loggedInUser = username;
        }

        private static void Register(string username, string password, string confirmPassword)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }

            if(password != confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }

            users[username] = password;

            File.AppendAllText(dbPath, $"{username} {password} \r\n");
        }
    }
}
