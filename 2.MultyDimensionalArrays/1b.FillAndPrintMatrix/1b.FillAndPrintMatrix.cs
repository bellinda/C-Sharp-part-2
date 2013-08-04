using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int number = 1;
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (cols % 2 == 0)
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        matrix[rows, cols] = number;
                        number++;
                    }
                }
                else if (cols % 2 == 1)
                {
                    for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
                    {
                        matrix[rows, cols] = number;
                        number++;
                    }
                }
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0,3}", matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
