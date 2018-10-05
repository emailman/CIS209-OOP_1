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
            
            Reports(accounts, "Opening Report");

            // Do some transactions
            accounts[0].Withdraw(150);
            Console.WriteLine($"{accounts[0].GetName()}: Withdraw $150");

            accounts[1].Deposit(100);
            Console.WriteLine($"{accounts[1].GetName()}: Deposit $100");

            accounts[2].Deposit(75);
            Console.WriteLine($"{accounts[2].GetName()}: Deposit $75");

            Reports(accounts, "\nClosing Report");
        }

        static void Reports(Account1[] accts, string heading)
        {
            Console.WriteLine(heading);
            Console.WriteLine("--------------");
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
