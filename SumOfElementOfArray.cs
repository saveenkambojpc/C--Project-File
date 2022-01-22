using System;


namespace Project
{
    class SumOfElementOfArray
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (int e in arr)
            {
                sum += e;
            }

            Console.Write("The Sum is ");
            Console.Write(sum);

            // Aliter : automatically call ToString()
            // Console.Write("The Sum is : "+sum);




        }
    }
}