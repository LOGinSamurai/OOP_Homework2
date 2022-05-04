using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homewok2
{
    public class Fish : Animal
    {
        public string scalesColor;
        public Fish() : base()
        {
            scalesColor = "blue";
        }
        public override void voice()
        {
            Console.WriteLine("...");
        }
    }
}
