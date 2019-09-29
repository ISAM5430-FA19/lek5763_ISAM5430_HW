using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest = int.MinValue;
            int count = 0;
            
            while (true)
            {
                Console.WriteLine("Enter a sequence of increasing numbers");
                int n = int.Parse(Console.ReadLine());
                if ( largest < n || count == 0)
                {
                    largest = n;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"The largest value is {largest}");
        }
    }
}
