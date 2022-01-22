using System;

namespace Project
{
    public class Employee
    {
        public Employee() //Constructor
        {
            Console.WriteLine("Constructor Invoked ");
        }
        ~Employee() //Destructor
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class Destrutor
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
        }
    }
}