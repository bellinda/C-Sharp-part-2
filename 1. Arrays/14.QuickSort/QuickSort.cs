using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long will be your array?");
            int n = int.Parse(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int i = 0; i < n; i++)
            {
                unsorted[i] = Console.ReadLine();
            }

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}
