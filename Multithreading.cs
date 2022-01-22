// C# program to illustrate the 
// concept of single threaded model
using System;
using System.Threading;



namespace Project
{


    // Driver class
    class Mutlithreading
    {
        public static void Method1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Method1 is {0}", i);

                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        public static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("-Method2 is {0}", i);

            }
        }
        static void Main(string[] args)
        {
            // Creating and initializing threads
            Thread thr1 = new Thread(Method1);
            Thread thr2 = new Thread(Method2);
            thr1.Start();
            thr2.Start();

        }
    }
}