using System;

namespace C14c
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Write(' ');
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
                
        }
    }
}
