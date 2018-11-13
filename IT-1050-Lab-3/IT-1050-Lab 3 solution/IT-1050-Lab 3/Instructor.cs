using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Lab_3
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CourseName { get; set; }


        public void setStudentGrade(Student Name, int theirgrade)
        {
            Name.Grade = theirgrade;
        }

        public string Print()
        {
            return FirstName + " " + LastName + " " + "teaches" + " " + CourseName;
        }

       
    }

}
