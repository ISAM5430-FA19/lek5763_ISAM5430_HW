using System;

namespace HW05
{
    class Account
    {
        public string Name { get; set; }
        private decimal balance;
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        public void Withdrawal(decimal withdrawAmount)
        {
            if (withdrawAmount <= balance)
            {
                Balance = Balance - withdrawAmount;
            }
            else
            {
                Balance = Balance;
                Console.WriteLine("Withdrawal amount exceeded account balance");
            }
        }
    }
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"subtracting {withdrawAmount:C} to account1 balance\n");
            account1.Withdrawal(withdrawAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter withdrawal amount for account2: ");
            decimal WithdrawAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"subtracting {withdrawAmount:C} to account2 balance\n");
            account2.Withdrawal(withdrawAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
        }
    }
}

