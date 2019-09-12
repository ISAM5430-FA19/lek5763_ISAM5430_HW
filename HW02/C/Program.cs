using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your GPA in decimal number between 0 and 4");
            decimal gpa = decimal.Parse(Console.ReadLine());
            if ((gpa < 0) || (gpa > 4))
            {
                Console.WriteLine("Invalid GPA");
            }
            else
            {
                string grade = null;
                int GPA = (int)(3 * gpa + 0.5m);
                if ((GPA == 11) || (GPA == 12))
                {
                    grade = "A";
                }
                else if ((GPA == 8) || (GPA == 9) || (GPA == 10))
                {
                    grade = "B";
                }
                else if ((GPA == 5) || (GPA == 6) || (GPA == 7))
                {
                    grade = "C";
                }
                else if ((GPA == 3) || (GPA == 4))
                {
                   grade = "D";
                }
                else
                {
                   grade = "F";
                }
                if ((GPA == 11) || (GPA == 8) || (GPA == 5))
                {
                    Console.WriteLine(grade + "-");
                }
                else if ((GPA == 10) || (GPA == 7) || (GPA == 4))
                {
                    Console.WriteLine(grade + "+");
                }
                else if (GPA == 12)
                {
                    Console.WriteLine("Grade A");
                }
                else if (GPA == 9)
                {
                    Console.WriteLine("Grade B");
                }
                else if (GPA == 6)
                {
                    Console.WriteLine("Grade C");
                }
                else if (GPA == 3)
                {
                    Console.WriteLine("Grade D");
                }
                else
                    Console.WriteLine("Grade F");
            }

        }
    }
}
