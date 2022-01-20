using System;

namespace Project
{
    class SortingOfArray
    {
        static void Main()
        {

            // Creating an Array
            int[] arr = { 45, 62, 1, 5 };

            // Printing unsorted Array
            Console.Write("Unsorted Array : ");
            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }


            // Selection Sorting Algorith
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            // Printing the Sorted Array
            Console.Write("\nSorted Array: ");
            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }

        }
    }
}

/*

    int n = 4;
    int arr[n] = {33, 98, 22,7};

    //^________________Selection Sorting__________________________
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            cout << endl;
            cout << "Before If Value of arr[i] :" << arr[i] << endl;
            cout << "Value is :" << arr[j] << "<" << arr[i] << endl;

            if (arr[j] < arr[i])
            {
                cout << "If Condition is running" << endl;
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }
            cout << "After If Value of arr[i] :" << arr[i] << endl;

            for (int i = 0; i < n; i++)
            {
                cout << arr[i] << " ";
            }
            cout << "___________________________________Iteration Completed" << endl;
            cout << endl;
        }
        cout << "Value of i updated" << endl;
    }
*/