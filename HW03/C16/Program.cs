using System;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(0 + ",");
                }
                for (int k = i; k > 0; k--)
                {
                    Console.Write(k + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
