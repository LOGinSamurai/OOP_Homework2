using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok2
{
    public class Animal
    {
        public double height;
        public double weight;
        public int age;
        public Animal()
        {
            height = 1;
            weight = 1;
            age = 1;
        }
        public virtual void voice()
        {
            Console.WriteLine("AAAAAAA");
        }
        public static void chekIfMature(object obj, int age)
        {
            if (obj is Dog && age >= 1)
            {
                Console.WriteLine("Your dog is mature");
            }
            else if (obj is Fish && age >= 2)
            {
                Console.WriteLine("Your fish is mature");
            }
            else if (obj is Dog && age < 1)
            {
                Console.WriteLine("Your dog is immature");
            }
            else if (obj is Fish && age < 2)
            {
                Console.WriteLine("Your fish is immature");
            }
            /*        else if (obj is Animal)
                    {
                        Console.WriteLine("We are not shure because all animals are different");
                    }*/
        }
    }
}
