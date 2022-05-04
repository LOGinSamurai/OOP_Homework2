using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok2
{
    public class Dog : Animal
    {
        public string furrColor;
        public Dog() : base()
        {
            furrColor = "white";
        }
        public override void voice()
        {
            Console.WriteLine("Bark");
        }
    }

}
