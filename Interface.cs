using System;

namespace Project
{
    interface Animal
    {
        void AnimalSound();
    }

    class Pig : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.AnimalSound();
        }
    }
}