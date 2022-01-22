using System;

namespace Project{

    class Employee{

        private string name;
        private int eId;

        Employee(string name,int eId){
            this.name = name;
            this.eId = eId;
            Console.WriteLine("Name is : "+name+" and Id is : "+eId);
        }
        static void Main(){
            
            new Employee("ABC", 45);
        }
    }
}