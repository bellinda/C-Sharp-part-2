using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());    //broi chisla v masiva
            int[] arr = new int[n];
            int number;
            int helper = 0;
            int n1 = n / 2;         //dyljina na parviq polumasiv
            int n2 = n - n1;         // dyljina na vtoriq polumasiv
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }
            for (int i = 0; i < n1; i++)
            {
                left.Add(arr[i]);
            }
            for (int j = n1; j < n; j++)
            {
                right.Add(arr[j]);
            }
            left.Sort();
            right.Sort();
            int m = 0;
            int l = 0;
            for (int k = 0; k < n; k++)
            {
                if ((m < n1) && (l<n2))
                {
                    if (left[m] <= right[l])
                    {
                        arr[k] = left[m];
                        m++;
                    }
                    else if (right[l] < left[m])
                    {
                        arr[k] = right[l];
                        l++;
                    }
                }
                else if(m >= n1)
                {
                    while (l <= n2)
                    {
                        arr[k] = right[l-1];
                        l++;
                    }
                }
                else if (l >= n2)
                {
                    while (m < n1)
                    {
                        arr[k] = left[m];
                        m++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
                if (i != n - 1)
                {
                    Console.Write(" ");
                }
            }
        }
    }
