using System;

namespace Participation_9
{
    public class Program
    {
        public static int[] SumArray(int[] a, int[] b)
        {
            int length = a.Length >= b.Length ? a.Length : b.Length;
            int[] c = new int[length];
            int i = a.Length - 1;
            int j = b.Length - 1;
            for (int k = c.Length - 1; k >= 0; k--)
            {
                if (a.Length > b.Length)
                {
                    c[k] = j < 0 ? a[i] : a[i] + b[j];
                }
                else if (a.Length < b.Length)
                {
                    c[k] = i < 0 ? b[j] : a[i] + b[j];
                }
                else
                {
                    c[k] = a[i] + b[j];
                }
                i--;
                j--;
            }

            return c;
        }

        static void Main()
        {
            int[] a = { 2, 4, 6, 3, 5 };
            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = SumArray(a, b);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}


            



            
        
        
        
        
        
        
        
         
