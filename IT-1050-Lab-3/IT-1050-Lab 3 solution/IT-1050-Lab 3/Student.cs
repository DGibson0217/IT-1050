using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Student
    {
        public string Name { get; set;}
        public int Grade { get; set; }
        public Instructor Teacher { get; set; }
        public string CourseName { get; set; }

        public void Print()
        {
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My grade is " + Grade);
            Console.WriteLine("Im in " + CourseName);
            Console.WriteLine("My Teacher is " + Teacher.FirstName);
        }
    }
}
