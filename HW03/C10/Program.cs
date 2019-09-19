using System;

namespace C10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("X");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("X");
                     
                }
                Console.WriteLine();
            }
        }
    }

}
 