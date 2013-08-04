using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int number = 1;

            //logic up to the diagonal
            matrix[n - 1, 0] = number;
            number++;
            int row = n-2;
            int rowCopy = row;
            int counter = 1;
            while (counter <= n - 1)
            {
                for (int cols = 0; cols <= counter; cols++)
                {
                    matrix[row, cols] = number;
                    row++;
                    number++;
                }
                counter++;
                row = rowCopy;
                row--;
                rowCopy = row;
            }

            //logic behind the diagonal

            row = 0;
            int indexCols = 1;
            while (counter > 0)
            {
                for (int col = indexCols; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number;
                    row++;
                    number++;
                }
                counter--;
                row = 0;
                indexCols++;
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0,4}", matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
