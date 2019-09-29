using System;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 123456789;
            int lastDigit = 0;
            Console.WriteLine("Enter a possitive integer");
            inputNumber = int.Parse(Console.ReadLine());
            while (inputNumber > 0)
            {
                lastDigit = inputNumber % 10;
                Console.Write(lastDigit);
                inputNumber = inputNumber / 10;
               
            }
        }
    }
}
                
            