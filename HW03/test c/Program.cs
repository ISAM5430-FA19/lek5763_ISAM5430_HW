using System;

namespace test_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a non-negative number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + ",");
                }
                Console.WriteLine();
            }
        }
    }
}




