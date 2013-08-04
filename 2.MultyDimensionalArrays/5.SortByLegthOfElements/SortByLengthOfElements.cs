using System;
using System.Collections.Generic;
    class SortByLengthOfElements
    {
        static void Main()
        {
            Console.Write("how long will be your array of strings? ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }

            SortByLength(n, arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void SortByLength(int n, string[] arr)
        {
            string temp = "";
            int counter = 0;
            while (counter < arr.Length)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i].Length > arr[i + 1].Length)   //exchanging the elements in the array
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                counter++;
            }
        }
    }
