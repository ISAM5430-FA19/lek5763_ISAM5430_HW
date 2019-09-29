using System;

namespace B8_Boolean_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastDigit = 0;
            bool hadNoneLeadingZero = false;
            Console.WriteLine("Enter integer a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer b");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            while (sum > 0)
            {
                lastDigit = sum % 10;
                if (hadNoneLeadingZero)
                {
                    Console.Write(lastDigit);
                }
                else
                {
                    if (lastDigit != 0)
                    {
                        hadNoneLeadingZero = true;
                        Console.Write(lastDigit);
                    }
                }
                sum = sum / 10;
            }
        }
    }
}
