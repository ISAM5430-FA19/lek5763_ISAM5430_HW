using System;

namespace C13b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                double result = (double)Math.Pow(d, i);
                Console.WriteLine($"{d}^{i} = {result}");
            }
        }
    }
}


            
