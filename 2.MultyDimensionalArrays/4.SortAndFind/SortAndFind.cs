using System;
using System.Collections.Generic;
    class SortAndFind
    {
        static void Main()
        {
            Console.Write("How many numbers are in your array? ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)   //filling the array with integers
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Which number is your K? ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            int index = Array.BinarySearch(arr, k);    //for example index = -4 => k should be on the 3rd position(counting from 0) in our array
            if (index > 0)
            {
                Console.WriteLine("The largest number <= K in your array is {0}", arr[index]);
            }
            else if (index == -1)
            {
                Console.WriteLine("There is no integer in your array which is <= K!");
            }
            else
            {
                Console.WriteLine("The largest number <= K in your array is {0}", arr[index * (-1) - 2]);
            }
        }
    }

