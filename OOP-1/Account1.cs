namespace OOP_1
{
    class Account1
    {
        // Instance variables
        private readonly string name;
        private decimal balance;

        public Account1(string acctName, decimal acctBalance = 0)
        {
            name = acctName;
            balance = acctBalance;
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        private void SetBalance(decimal amt)
        {
            balance = amt;
        }

        public void Deposit(decimal amt)
        {
            SetBalance(GetBalance() + amt);
        }

        public void Withdraw(decimal amt)
        {
            SetBalance(GetBalance() - amt);
        }

        override public string ToString()
        {
            return $"Account: {name} / Balance = {balance:C}";
        }
    }
}
