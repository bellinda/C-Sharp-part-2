using System;
using System.Collections.Generic;
    class FindMaxAndSort
    {
        static int FindMax(List<int> array, int index)
        {
            int max = array[index];
            for (int i = index + 1; i < array.Count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            //Console.WriteLine(max);
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("How long will be your array? ");
            int n = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();
            List<int> arrCopy = new List<int>();
            Console.WriteLine("Enter your numbers: ");
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr.Add(a);
                arrCopy.Add(a);
            }
            Console.Write("From which index is starting your searching for a maximal element? ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindMax(arr, index)); //finding the maximal element in this part of the array, that starts at choosen index

            Console.WriteLine();
            Console.WriteLine("Your array in descending order: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FindMax(arr, 0) + " ");
                //int temp = (int)FindMax(arr, 0);
                arr.Remove(FindMax(arr, 0));
            }

            Console.WriteLine();
            List<int> sorted = new List<int>();
            Console.WriteLine("Your array in ascending order: ");
            for (int i = 0; i < n; i++)
            {
                sorted.Add(FindMax(arrCopy, 0));
                arrCopy.Remove(FindMax(arrCopy, 0));
            }
            for (int i = sorted.Count - 1; i > 0; i--)
            {
                Console.Write(sorted[i] + " ");
            }
        }
    }
