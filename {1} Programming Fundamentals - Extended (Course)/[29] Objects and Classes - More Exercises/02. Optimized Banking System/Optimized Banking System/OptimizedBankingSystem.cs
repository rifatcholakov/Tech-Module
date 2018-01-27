using System;
using System.Collections.Generic;
using System.Linq;

namespace Optimized_Banking_System
{

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            List<BankAccount> list = new List<BankAccount>();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                BankAccount currentInput = BankAccount.Parse(input);

                list.Add(currentInput);

                input = Console.ReadLine();
            }

            list
                .OrderByDescending(x => x.balance)
                .ThenBy(x => x.bank.Length)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",
                account.name,
                account.balance,
                account.bank)
                );
        }
    }
}
