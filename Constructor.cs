using System;

namespace Project{
    class ConstructorExample{

        ConstructorExample(){
            Console.WriteLine("Constuctor is Called");
        }
        static void Main(string [] args){

            // Calling the Constructor
            new ConstructorExample();
            
        }
    }
}