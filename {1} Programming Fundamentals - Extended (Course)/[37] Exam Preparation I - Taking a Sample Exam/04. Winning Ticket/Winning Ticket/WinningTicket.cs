using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            const string pattern = @"([$#@^])\1{5,}";

            Regex ticketRegex = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                } 

                string leftHalf = ticket.Substring(0, ticket.Length / 2);
                string rightHalf = ticket.Substring(ticket.Length / 2);

                Match leftMatch = ticketRegex.Match(leftHalf);
                Match rightMatch = ticketRegex.Match(rightHalf);

                if(leftMatch.Success && rightMatch.Success)
                {
                    int ticketLength = Math.Min(leftMatch.Length, rightMatch.Length);
                    char winningSymbol = leftMatch.Value[0];

                    string jackpot = string.Empty;

                    if(ticketLength == 10)
                    {
                        jackpot = " Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {ticketLength}{winningSymbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
