using System;
using static System.Console;

namespace HW04
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Permuation set");
            int i = 0;
            int j = 0;
            int k = 0;
            int sum_pro = 0;
            WriteLine("Enter the numbers in a set from 1-3");
            int n = int.Parse(ReadLine());

            for (i = 1; i <= 5; i++)
            {
                if (n == 1)
                {
                    Write($"{i}");
                }
                else if (n == 2)
                {
                    for (j = 1; j <= 5; j++)
                    {
                        if (j != i)
                        {
                            Write(i + ", " + j + "; ");
                            sum_pro += i * j;
                        }
                    }
                }
                else if (n == 3)
                {
                    for (j = 1; j <= 5; j++)
                    {
                        if (i != j)
                        {
                            for (k = 1; k <= 5; k++)
                            {
                                if (k != i && k != j)
                                {
                                    Write(i + ", " + j + ", " + k + "; ");
                                    sum_pro += i * j * k;
                                }
                            }
                        }
                    }
                }
            }
            WriteLine();
            WriteLine($"Sum products is {sum_pro}");
        }
    }
}

                                
