using System;

namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some accounts in an array
            Account1[] accounts = {
                                    new Account1("Dopey", 500),
                                    new Account1("Sleepy"),
                                    new Account1("Sneezy", 300)
                                   };

            Console.WriteLine("Opening Report");
            Console.WriteLine("--------------");
            Reports(accounts);

            // Do some transactions
            accounts[0].Withdraw(150);
            accounts[1].Deposit(100);
            accounts[2].Deposit(75);

            Console.WriteLine("Closing Report");
            Console.WriteLine("--------------");
            Reports(accounts);
        }

        static void Reports(Account1[] accts)
        {
            Console.WriteLine("List of accounts and balances:");
            foreach (var acct in accts)
                Console.WriteLine(acct);
            Console.WriteLine();

            Console.WriteLine("List of account names:");
            foreach (var acct in accts)
                Console.WriteLine(acct.GetName());

            Console.Write("\nTotal Balance = ");
            decimal balance = 0;
            foreach (var acct in accts)
                balance += acct.GetBalance();
            Console.WriteLine($"{balance:C}\n");
        }
    }
}
