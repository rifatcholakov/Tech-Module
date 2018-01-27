using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hornet_Comm
{
    public class HornetComm
    {
        public static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "Hornet is Green")
                {
                    break;
                }

                string[] parts = line.Split(
                    new[] {" <-> "}, 
                    StringSplitOptions.RemoveEmptyEntries);

                if(parts.Length != 2)
                {
                    continue;
                }

                string firstQuery = parts[0];
                string secondQuery = parts[1];

                if (firstQuery.All(char.IsDigit)
                    && secondQuery.All(char.IsLetterOrDigit))
                {
                    string revercedQuery = new string(firstQuery.Reverse().ToArray());

                    messages.Add($"{revercedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(s => !char.IsDigit(s))
                    && secondQuery.All(char.IsLetterOrDigit))
                {
                    StringBuilder transformed = new StringBuilder();

                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            transformed.Append(symbol.ToString().ToLower());
                        }
                        else if (char.IsLower(symbol))
                        {
                            transformed.Append(symbol.ToString().ToUpper());
                        }
                        else
                        {
                            transformed.Append(symbol);
                        }
                    }

                    broadcasts.Add($"{transformed} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any()
                ? string.Join(Environment.NewLine, broadcasts)
                : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");
        }
    }
}
