using System;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            int quotient = 0;
            int remainder = 0;
            Console.WriteLine("Enter a positive integer");
            int n = int.Parse(Console.ReadLine());
            if (n == 0 || n == 1)
            {
                Console.Write(n);
            }
            else
            {
                while (n / 2 > 0)
                {
                    quotient = n / 2;
                    remainder = n % 2;
                    result += remainder;
                    n = quotient;
                    if (n / 2 == 0)
                    {
                        result += n % 2;
                    }
                }
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    Console.Write(result[i]);
                }
            }
        }
    }
}

             