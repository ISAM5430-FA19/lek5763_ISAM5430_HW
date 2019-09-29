using System;
using static System.Console;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dmin = int.MaxValue;
            int closet_num = 0;
            WriteLine("Enter an item");
            int item = int.Parse(Console.ReadLine());
            WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            while (n != item)
            {
                int d = Math.Abs(n - item);
                if (d < dmin)
                {
                    dmin = d;
                    closet_num = n;
                }
                WriteLine($"The closest number so far is {closet_num}");
                WriteLine("Enter a number");
                n = int.Parse(ReadLine());
            }
            WriteLine("The number is now matching the item");
        }
                
    }
}
