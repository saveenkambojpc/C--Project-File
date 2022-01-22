using System;

namespace Project
{
    abstract class Animal1
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Dog : Animal1
    {
        public override void animalSound()
        {
            Console.WriteLine("Dog is Barking");
        }
    }

    class AbstractExample
    {
        static void Main(string[] args)
        {
            // Animal1 animal1 = new Animal1(); //Error 

            Dog dog = new Dog();
            dog.animalSound();

        }
    }
}