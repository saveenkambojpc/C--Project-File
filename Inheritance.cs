using System;

namespace Project
{
    
    class Vehicle
    {
        public string brand = "Ford";
    }
    // Single Inheritance
    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    

    class Inheritance
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.brand); //Ford
        }
    }
}