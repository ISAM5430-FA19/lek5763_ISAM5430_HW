using System;
using static System.Console;

namespace B1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int sum_pro = 0;
            WriteLine("Combinations set");
            WriteLine("Enter the numbers in a set");
            int n = int.Parse(ReadLine());
            for (i = 1; i <= 5; i++)
            {
                if (n == 2)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        Write(i + ", " + j + "; ");
                        sum_pro += i * j;
                    }
                }
                else if (n == 3)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            Write(i + ", " + j + ", " + k + "; ");
                            sum_pro += i * j * k;
                        }
                    }
                }
                else if (n == 4)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            for (l = k + 1; l <= 5; l++)
                            {
                                Write(i + ", " + j + ", " + k + ", " + l + "; ");
                                sum_pro += i * j * k * l;
                            }
                        }
                    }
                }
                else if (n == 5)
                {
                    for (j = i + 1; j <= 5; j++)
                    {
                        for (k = j + 1; k <= 5; k++)
                        {
                            for (l = k + 1; l <= 5; l++)
                            {
                                for (m = l + 1; m <= 5; m++)
                                {
                                    Write(i + ", " + j + ", " + k + ", " + l + ", " + m + "; ");
                                    sum_pro += i * j * k * l * m;
                                }
                            }
                        }
                    }
                }
            }
            WriteLine();
            WriteLine($"Sum products is { sum_pro}");
        }
    }
}
                