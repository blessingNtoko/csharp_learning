using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Student
    {
        public string studentName;
        public string course;
        public double gpa;

        public Student(string studentName, string course, double gpa)
        {
            this.studentName = studentName;
            this.course = course;
            this.gpa = gpa;
        }   

        public bool HasHonours()
        {
            Console.WriteLine(this);
            if (this.gpa > 3.5)
            {
                return true;
            }

            return false;
        }
    }
}
