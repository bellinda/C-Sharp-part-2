using System;
using System.Collections.Generic;
    class SquareWithMaxSum
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            int currentSum;
            int bestIndexRow = 0;
            int bestIndexCol = 0;
            //fill the matrix
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                        bestIndexRow = row;
                        bestIndexCol = col;
                    }
                }
            }

            //print the square with best sum:
            for (int row = bestIndexRow; row < bestIndexRow + 3; row++)
            {
                for (int col = bestIndexCol; col < bestIndexCol + 3; col++)
                {
                    Console.Write("{0,4}", matrix[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
