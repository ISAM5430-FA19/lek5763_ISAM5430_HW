using System;

namespace C14a
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                string display = "";
                Console.WriteLine(display);
                for(int j = 1; j <= i; j++)
                {
                    display += "*";
                    
                }
                Console.Write(display);
            }
        }
    }
}
