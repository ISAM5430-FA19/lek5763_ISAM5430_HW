using System;

namespace C5
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date(int aMonth, int aDay, int aYear)
        {
            Month = aMonth;
            Day = aDay;
            Year = aYear;
        }
        //DisplayDate method
        public void DisplayDate()
        {
        
            Console.WriteLine($"The date entered is: {Month}/ {Day}/ {Year}");
        }

    }

    class DateTest
    {
        static void Main()
        {
            Console.Write("\nEnter a month: ");
            int aMonth = int.Parse(Console.ReadLine());
            Console.Write("\nEnter a day: ");
            int aDay = int.Parse(Console.ReadLine());
            Console.Write("\nEnter a year: ");
            int aYear = int.Parse(Console.ReadLine());
            Date date = new Date(aMonth, aDay, aYear);
            date.DisplayDate();
        }
    }
}

         
