using System;

namespace try1
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1000;
            double amount = p;
            double rate = 0.05;
            Console.WriteLine("Enter the number of years");
            double n = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                amount = p * (double)Math.Pow((1 + rate), i);
                Console.WriteLine($"Year {i}: {amount:C}");
            }
        }
    }
}



 