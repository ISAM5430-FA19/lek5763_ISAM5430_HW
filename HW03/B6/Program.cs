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

            while (n > 0)
            {
                Console.WriteLine("Enter a possitive number");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    if(min != int.MaxValue)
                    {
                        count++;
                   
                    }
                    break;   
                }
                display += n + ", ";
                if (n < min)
                {
                    min = n;
                }
                else if (n >= min * min)
                {
                    display = display.Remove(display.Length - 2);
                    display += " | ";
                    Console.WriteLine(display);
                    count++;
                    min = int.MaxValue;
                }
            }
            display += n;
            Console.WriteLine(display);
            Console.WriteLine($"Number of sets: {count}");
            
        }
    }
}


                     
                    
                    



        
        
        
    



