using Polymorphism_Abstraction_Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static Polymorphism_Abstraction_Interface.Person;

namespace Polymorphism_Abstraction_Interface
{
    public class Person : Test, ISpeak,IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person Eating " + DateTime.Now);
        }

        public void Speak()
        {
            Console.WriteLine("Person Speaking");
        }

    }
   
    
        


    

    

}
