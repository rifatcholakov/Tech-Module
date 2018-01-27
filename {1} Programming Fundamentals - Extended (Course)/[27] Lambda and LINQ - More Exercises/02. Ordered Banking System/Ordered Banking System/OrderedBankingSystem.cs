using System;
using System.Collections.Generic;
using System.Linq;

namespace Ordered_Banking_System
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> banksAndAccount = new Dictionary<string, Dictionary<string, decimal>>();

            string inputLine = Console.ReadLine();

            while(inputLine != "end")
            {
                string[] inputParams = inputLine.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string bankName = inputParams[0];
                string bankAccountName = inputParams[1];
                decimal bankAccountBalance = decimal.Parse(inputParams[2]);

                if (!banksAndAccount.ContainsKey(bankName))
                {
                    banksAndAccount.Add(bankName, new Dictionary<string, decimal>());
                }

                if (!banksAndAccount[bankName].ContainsKey(bankAccountName))
                {
                    banksAndAccount[bankName].Add(bankAccountName, 0);
                }

                banksAndAccount[bankName][bankAccountName] += bankAccountBalance;

                inputLine = Console.ReadLine();
            }

            banksAndAccount
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value.OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",
                account.Key,
                account.Value,
                bank.Key)
                ));
        }
    }
}
