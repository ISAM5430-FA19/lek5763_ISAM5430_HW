using System;

namespace C2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = 100;
            while ((num >= 1) && (num <= 100))
            {
                Console.WriteLine(num);
                num = num / 2;
            }
        }
    }
}
