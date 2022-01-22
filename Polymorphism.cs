using System;

namespace Project
{
    class AnimalClass
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }
    class PigClass : AnimalClass
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }

    class Polymorphism
    {
        static void Main(string[] args)
        {
            AnimalClass animal = new AnimalClass();
            animal.AnimalSound(); //The animal make a sound

            PigClass pig = new PigClass();
            pig.AnimalSound(); //The pig says : wee wee
        }
    }
}