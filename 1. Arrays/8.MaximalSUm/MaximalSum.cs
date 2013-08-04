using System;
using System.Collections.Generic;
    class MaximalSum
    {
        static void Main()
        {
            int count = 0;
            int p = 1;
            int k = 0;
            int result = int.MinValue;
            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;
            List<int> startIndexes = new List<int>();
            List<int> endIndexes = new List<int>();
            List<int> sums = new List<int>();
            List<int> numbers = new List<int>();
            Console.Write("How many numbers will you type in? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                numbers.Add(m);
            }
            sum = numbers[0];
            startIndexes.Add(k);
            sums.Add(0);
            do
            {
                sum += numbers[p];
                sums.Add(sum);
                if (sum > result)
                {
                    result = sum;
                    startIndex = k;
                    endIndex = p;
                }
                p++;
                count++;
                if (p == n)
                {
                    if (k != (n - 1))
                    {
                        sum = numbers[++k];
                        startIndexes.Add(k);
                    }
                    p = p - count + 1;
                    count = 0;
                }
            }
            while((p<n)&&(p>=0));
            Console.WriteLine("Start index = {0} and End index = {1}, result = {2}", startIndex, endIndex, result);
            Console.Write("The sequence of maximal sum is: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.Write("\b");
            Console.Write("\b");
            Console.Write("\t");
        }
    }
