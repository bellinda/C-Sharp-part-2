using System;
using System.Collections.Generic;
using System.Linq;
    class SelectionSort
    {
        static void Main()
        {
            Console.Write("How many elemnts do you want to have in your list? ");
            int N = int.Parse(Console.ReadLine());
            List<int> toBeSorted = new List<int>();
            List<int> sorted = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int k = int.Parse(Console.ReadLine());
                toBeSorted.Add(k);
            }

            //First version:

            for (int i = 0; i < N; i++)
            {
                sorted.Add(toBeSorted.Min());
                toBeSorted.Remove(toBeSorted.Min());
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(sorted[i]);
            }

            //Second version:

            toBeSorted.Sort();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(toBeSorted[i]);
            }
        }
    }
