using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"{ num1} is larger");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} is larger");
            }
            else
            {
                Console.WriteLine("Both numbers are the same");
            }
        }
    }
}
