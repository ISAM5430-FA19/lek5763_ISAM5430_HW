using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int p = 0;
            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                if ((p != n) || (count == 0))
                {
                    p = n;
                    sum += p;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

 

