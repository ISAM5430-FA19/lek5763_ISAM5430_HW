using System;

namespace C3
{
    public class Money
    {
        public Money(decimal dollars, decimal cents)
        {
            Cents = cents;
            Dollars = dollars + cents / 100;
        }
        public Money(decimal dollars)
        {
            Dollars = dollars;
        }
        private decimal Dollars { get; set; }
        private decimal Cents { get; set; }
        public decimal IncrementMoney()
        {
            return Dollars++; 
        }
        public decimal DecrementMoney()
        {
            return Dollars--;
        }
        public string MoneyValue()
        {
            decimal quarters = Dollars * 4;
            decimal nickels = Dollars * 20;
            decimal dimes = Dollars * 10;
            decimal pennies = Dollars * 100;
            return $"Dollar amount: {Dollars}\n Quarter amount: {quarters}\n Nickel amount: {nickels}\n Dime amount : {dimes}\n Penny amount: {pennies}";
        }
        public override string ToString()
        {
            return $"${Dollars}";
        }
    }
    class MoneyTest
    {
        static void Main()
        {
            Money money1 = new Money(1.0m, 50.0m);
            Money money2 = new Money(2.0m);
            money1.IncrementMoney();
            money2.DecrementMoney();
            Console.WriteLine(money1.MoneyValue());
            Console.WriteLine(money2.MoneyValue());
            Console.WriteLine(money1);
            Console.WriteLine(money2);
        }
    }
}
                
                   
