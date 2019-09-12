using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 1, 1 };
            int clump = 0;
            bool flag = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] == array[i] && !flag)
                {
                    flag = true;
                    clump += 1;
                }
                else if (array[i + 1] != array[i])
                {
                    flag = false;
                }

            }
        }
    }
}
