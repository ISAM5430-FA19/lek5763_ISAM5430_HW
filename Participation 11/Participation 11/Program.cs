using System;

namespace Participation_11
{
    class Program
    {
        public static bool RepeatedValue(int[] array, int n)
        {
            if (array == null || array.Length == 0 || n <= 0)
            {
                return false;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
                if (count == n)
                {
                    return true;
                }
            }
            return false;
        }




        //Test method
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 3, 4, 5, 6, 4, 7, 4, 9 };
            int n = 3;
            bool result = RepeatedValue(array, n);
            Console.WriteLine(result);
        }
    }
}