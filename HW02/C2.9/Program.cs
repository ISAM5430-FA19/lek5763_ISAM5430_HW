using System;

namespace C2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            while ((num >= 0) && (num <= 100))
            {
                Console.WriteLine(num);
                num = num / 2;
            }
        }
    }
}
