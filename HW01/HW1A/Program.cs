using System;

namespace HW1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operator: (+, -, *, /)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                int sum = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {sum}");
            }
            if (op == "-")
            {
                int diff = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {diff}");
            }
            if (op == "*")
            {
                int pro = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {pro}");
            }
            if (op == "/")
            {
                int div = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {div}");
            }
        }
    }
}

