using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//для втрого пункта дз
namespace OOP_Homework2_part2
{
    public class UsersWorker : User
    {
        private double salary;

        public UsersWorker() : base()
        {
            salary = 1;
        }
        public UsersWorker(string name, int age, double salary) : base(name,age)
        {
            this.salary = salary;
        }
        public double getSalary()
        {
            return salary;
        }
        public void setSalary(double value)
        {
            if (salary >= 0)
            {
                salary = value;
            }
        }
    }
}
