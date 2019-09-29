﻿using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;
            int max = int.MinValue;
             
            while (true)
            {
                Console.WriteLine("Enter your score");
                string s = Console.ReadLine();
                if (string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("No score entered");
                    break;
                }
                int score = int.Parse(s);
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid score");
                    break;
                }
                else
                {
                    sum = sum + score;
                    count++;
                    if (score > max)
                    {
                        max = score;
                    }
                }
                
            }
            //decimal avg = (decimal) sum / count; OR
            double avg = (double) sum / count;
            Console.WriteLine($"Average score is {avg:F}");
            Console.WriteLine($"Best score is {max}");
        }
    }
}



        






 

    



       
       
         

             
            
       
