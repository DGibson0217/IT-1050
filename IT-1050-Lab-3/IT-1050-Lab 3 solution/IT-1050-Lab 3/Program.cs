using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            Instructor John = new Instructor();
            John.FirstName = "John";
            John.LastName = "Ardin";
            John.CourseName = "English";

            Instructor Mike = new Instructor();
            Mike.FirstName = "Mike";
            Mike.LastName = "Hammell";
            Mike.CourseName = "Math";

            Student Jane = new Student();
            Jane.Name = "Jane";
            Jane.Teacher = John;
            Jane.CourseName = John.CourseName;

            Student Joe = new Student();
            Joe.Name = "Joe";
            Joe.Teacher = John;
            Joe.CourseName = John.CourseName;

            Student Melissa = new Student();
            Melissa.Name = "Melissa";
            Melissa.Teacher = Mike;
            Melissa.CourseName = Mike.CourseName;

            Student Matt = new Student();
            Matt.Name = "Matt";
            Matt.Teacher = Mike;
            Matt.CourseName = Mike.CourseName;
            #endregion

            #region Part 2

            Show.HorizontalDivider();
            Console.WriteLine(John.Print());
            Console.ReadLine();
            Console.WriteLine(Mike.Print());
            Console.ReadLine();
            Show.HorizontalDivider();
            

            John.setStudentGrade(Jane, 95);
            John.setStudentGrade(Joe, 85);
            Mike.setStudentGrade(Melissa, 90);
            Mike.setStudentGrade(Matt, 92);

            Jane.Print();
            Console.ReadLine();
            Joe.Print();
            Console.ReadLine();
            Melissa.Print();
            Console.ReadLine();
            Matt.Print();
          

            Show.HorizontalDivider();
            Console.ReadLine();
            #endregion
        }
    }
}
