using System;
    class ArrayMaxSum
    {
        static void Main()
        {
            int maxSum = 0;
            int j = 0;
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int[] sum = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N-(K-1); i++)
            {
                for (int k = 1; k <= K; k++)
                {
                    sum[i] += arr[j];
                    j++;
                    
                }
                j = j - (K-1);
            }
            for (int i = 0; i < (N-(K-1)); i++)
            {
                if ((sum[i] > sum[i + 1]) && (maxSum<sum[i]))
                {
                    maxSum = sum[i];
                }
            }
            Console.WriteLine("Maximum sum of {0} elements = {1}", K, maxSum);
        }
    }
