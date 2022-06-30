using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
        public override void Eat()
        {
            Console.WriteLine("Bird eating");

        }
    }

}
