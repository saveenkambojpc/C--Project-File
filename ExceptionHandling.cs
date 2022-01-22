using System;

namespace Project
{


    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("Some Important Code Here ...");
        }
    }
}