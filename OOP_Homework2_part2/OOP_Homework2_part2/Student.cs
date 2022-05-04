using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework2_part2
{
    public class Student : User
    {
        public int scholarship;
        public string course;
        public Student():base()
        {
            scholarship = 1000;
            course = "Programing";
        }

        public Student(string name, int age, int scholarship, string course) : base(name, age)
        {
            this.scholarship = scholarship;
            this.course = course;
        }
        public void Display()
        {
            Console.WriteLine("|scholarship: " + scholarship + "|");
            Console.WriteLine("|course: " + course + "|");
        }
    }
}
