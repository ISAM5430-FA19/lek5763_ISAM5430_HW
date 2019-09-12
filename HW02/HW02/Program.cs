using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int num3 = int.Parse(Console.ReadLine());
            if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
            {
                Console.WriteLine($"{num1} is in the middle");
            }
            else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
            {
                Console.WriteLine($"{num2} is in the middle");
            }
            else
            {
                Console.WriteLine($"{num3} is in the middle");

            }

        }
    }
}
