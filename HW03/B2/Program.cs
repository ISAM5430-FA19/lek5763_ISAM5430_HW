﻿using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int p = 0; // variable for previous number
            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                if (p != n || count == 0)
                {
                    p = n;
                    sum += n;
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

 

