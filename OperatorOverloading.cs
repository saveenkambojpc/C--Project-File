using System;

namespace Project
{

    class Calculator
    {
        public int num1, num2;

        // Constructor
        public Calculator(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public static Calculator operator -(Calculator c1)
        {
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }

        public void Print()
        {
            Console.WriteLine("Num1 = " + this.num1);
            Console.WriteLine("Num2 = " + this.num2);
        }
    }

    class OperatorOverloading
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(12, 23);

            calc = -calc;

            // To display the result
            calc.Print();
        }
    }
}