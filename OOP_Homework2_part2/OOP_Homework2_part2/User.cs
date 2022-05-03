using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework2_part2
{
    public class User
    {

        private string name;

        private int age;

        public User()
        {
            name = "John Doe";

            age = 22;
        }
        public User(string name, int age)
        {
            this.name = name;

            this.age = age;
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

        public int  getAge()
        {
            return age;
        }
        public void setAge(int value)
        {
            if (value != 0)
            {
                age = value;
            }
        }
    }
}
