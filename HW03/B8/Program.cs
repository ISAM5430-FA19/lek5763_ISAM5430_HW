using System;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int lastDigit = 0;
            Console.WriteLine("Enter integer a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer b");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            while (sum > 0)
            {
                lastDigit = sum % 10;
                if (lastDigit != 0 || count > 0)
                {
                    Console.Write(lastDigit);
                    count++;
                }
                sum = sum / 10;
            }
        }
    }
}

                 
            
        
