using System;

namespace C1
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal GPA { get; set; }
        public Student(string lname, string fname, decimal gpa)
        {
            LastName = lname;
            FirstName = fname;
            GPA = gpa;
        }
        //StudentInfo method
        public void StudentInfo()
        {
            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(FirstName) || GPA < 0)
            {
                Console.WriteLine("Invalid name or gpa enetered");
                return;
            }
            else
            {
                Console.WriteLine($"Student name: {LastName}, {FirstName}\nGPA: {GPA}");
            }
        }
    }
    class StudentTest
    {
        static void Main()
        {
            Console.WriteLine("Enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter gpa: ");
            decimal gpa = decimal.Parse(Console.ReadLine());
            Student studentinfo = new Student(lname, fname, gpa);
            studentinfo.StudentInfo();
        }
    }
}
           
        

         






        