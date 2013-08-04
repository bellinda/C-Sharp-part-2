//Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
    class SubsetOfKElements
    {
        static void Main()
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("S = ");
            int S = int.Parse(Console.ReadLine());
            bool checker = false;
            int counter = 0;

            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //int sumCounter = 0;
            int combinations = (int)Math.Pow(2, N);
            for (int i = 1; i < combinations; i++)
            {
                int tempSum = 0;
                for (int j = 0; j < N; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        tempSum += numbers[j];
                        counter++;
                    }
                    if (counter == K)                       //proverqva samo sumite, koito sa se poluchili ot K na broi elementa
                    {
                        if (tempSum == S)
                        {
                            checker = true;
                            break;
                        }
                    }
                    if (checker == true)
                    {
                        break;
                    }
                    
                }
                counter = 0;
                
            }
            if (checker == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
