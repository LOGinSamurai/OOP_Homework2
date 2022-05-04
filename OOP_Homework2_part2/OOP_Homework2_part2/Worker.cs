using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework2_part2
{
    public class Worker
    {

        private string name;

        private double salary;

        public Worker()
        {
        name = "John Doe";

        salary = 3301;
        }
        public Worker(string name, double salary )
        {
            this.name = name;

            this.salary = salary;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string value)
        {
            if (value != null)
            {
                name = value;
            }
        }

        public double getSalary()
        {
            return salary;
        }
        public void setSalary(int value)
        {
            if (value != 0)
            {
                salary = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("|Name: " + name + "| |Salary: " + salary + "|");
        }
    }
}
