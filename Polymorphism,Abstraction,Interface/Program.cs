using System;

namespace Polymorphism_Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird bird = new Bird();
            bird.Sound();
            bird.Eat();

            Dog dog = new Dog();
            dog.Sound();
            dog.Eat();
            
            Test test = new Test();
            test.Id = 6;
            Console.WriteLine(test.Id);

            Person person = new Person();
            person.Speak();
            person.Eating(DateTime.Now);
        }
    }
}
