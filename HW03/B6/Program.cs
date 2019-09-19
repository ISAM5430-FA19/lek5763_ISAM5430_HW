using System;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int min = int.MaxValue;
            int n = 1;
            string display = "";
            Console.WriteLine("Enter a possitive number");
            n = int.Parse(Console.ReadLine());

            while (n > 0)
            {

                count++;
                 
                if (n < min)
                {
                    min = n;
                }
                else if (n >= min * min)
                {
                    count++;
                    display += n + "|";
                    Console.WriteLine(display);
                    Console.WriteLine($"Number of sets: {count}");
                    Console.WriteLine("Enter a possitive number");
                    n = 1;
                    count = 0;
                    min = int.MaxValue;
                }
                if (count != 0)
                {
                    display += n + ", ";
                }
            }
            Console.WriteLine($"Number of sets: {count}");
            Console.WriteLine(display);
        }
    }
}


                     
                    
                    



        
        
        
    



