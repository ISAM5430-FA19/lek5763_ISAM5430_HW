using System;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool primeCheck = true;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
             
            for (int p = 1; p < int.MaxValue; p++)
            {
                for (int i = 2; i < 10; i++)
                {
                    primeCheck = true;

                    if (p % i == 0 && p != i)
                    {
                        primeCheck = false;
                        break;
                    }
                }
                if (primeCheck)
                {
                    Console.Write($" {p} ");
                    count++;
                    if (count >= n)
                    {
                        break;
                    }
                }
            }
        }
    }
}

                 
               
                
                 

            



                        
                         
                    
                










