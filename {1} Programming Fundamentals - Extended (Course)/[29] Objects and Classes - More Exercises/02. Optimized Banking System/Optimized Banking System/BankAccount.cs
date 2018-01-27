using System;

namespace Optimized_Banking_System
{
    public class BankAccount
    {
        public string name { get; set; }

        public string bank { get; set; }

        public decimal balance { get; set; }

        public static BankAccount Parse(string input)
        {
            string[] bankParts = input.Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new BankAccount
            {
                bank = bankParts[0],
                name = bankParts[1],
                balance = decimal.Parse(bankParts[2])
            };
        }

    }
}
