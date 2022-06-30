using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    public class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Mır Hav-av");
        }
        public override void Eat()
        {
            Console.WriteLine("Dog eating");
        }
    }
}
