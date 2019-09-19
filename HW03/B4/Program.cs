using System;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
             
            while(true)
            {
                Console.WriteLine("Enter side 1");
                int s1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side 2");
                int s2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side 3");
                int s3 = int.Parse(Console.ReadLine());
                if ((s1 <= 0) || (s2 <= 0) || (s3 <= 0))
                {
                    break;
                }
                else if (((s1 + s2) <= s3) || ((s1 + s3) <=  s2) || ((s2 + s3) <= s1))
                {
                    Console.WriteLine("Invalid triangle");
                }
                else
                {
                    Console.WriteLine("Valid triangle");
                }
            }
        }
    }
}
