using System;

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
                if (s == null)
                {
                    Console.WriteLine("No score entered");
                    break;
                }
                else
                {
                    int score = int.Parse(s);
                    if ((score >= 0) && (score <= 100))
                    {
                        sum = sum + score;
                        count++;
                        if (score > max)
                        {
                            max = score;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            decimal avg = (decimal)sum / count;
            Console.WriteLine($"Average score is {avg:F}");
            Console.WriteLine($"Best score is {max}");
        }
    }
}



        






 

    



       
       
         

             
            
       
