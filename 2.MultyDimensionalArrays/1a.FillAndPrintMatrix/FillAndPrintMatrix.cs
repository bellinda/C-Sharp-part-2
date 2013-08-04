using System;
using System.Collections.Generic;
    class FillAndPrintMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int number = 1;
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    matrix[rows, cols] = number;
                    number++;
                }
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write(matrix[rows,cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
