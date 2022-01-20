using System;

namespace Project
{
    class ReverseOrderOfArray
    {
        static void Main(String[] args)
        {
            // Creating an Loop
            int[] arr = { 54, 86, 12, 33 };

            // Decremental Loop
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}