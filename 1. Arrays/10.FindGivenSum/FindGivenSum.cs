using System;
using System.Collections.Generic;
    class FindGivenSum
    {
        static void Main()
        {
            Console.Write("How long array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Whitch sum do you want to look for? ");
            int S = int.Parse(Console.ReadLine());
            List<int> sums = new List<int>();
            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;
            int k = 0;
            int p = 1;
            int count = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            sum = arr[0];
            sums.Add(0);
            do
            {
                sum += arr[p];
                sums.Add(sum);
                if (sum == S)
                {
                    startIndex = k;
                    endIndex = p;
                }
                p++;
                count++;
                if (p == n)
                {
                    if (k != (n - 1))
                    {
                        sum = arr[++k];
                    }
                    p = p - count + 1;
                    count = 0;
                }
            }
            while ((p < n) && (p >= 0));
            if (sums.Contains(S))
            {
                Console.Write("The sequence with sum S = {0} is: ", S);
                for (int i = startIndex; i <= endIndex; i++)
                {
                    Console.Write(arr[i] + ", ");
                }
                Console.Write("\b");
                Console.Write("\b");
                Console.Write("\t");
            }
            else
            {
                Console.WriteLine("There is no sequence in this array, whitch sum is S = {0}.", S);
            }

        }
 
    }
