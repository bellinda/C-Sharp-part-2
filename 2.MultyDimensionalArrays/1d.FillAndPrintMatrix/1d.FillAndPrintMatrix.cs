using System;
using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int number = 1;
            int col = 0;
            int row = 0;
            int counter = 1;
            int counterRowsDown = 0;
            int counterRowsUp = 0;
            int counterColsLeft = 0;
            int counterColsRight = 0;
            while (counter <= 2 * n - 1)
            {
                if (counter % 2 == 1)
                {
                    if ((row < n - counterRowsDown) && (row != n - counterRowsDown - 1))
                    {
                        while (row < n - counterRowsDown)
                        {
                            matrix[row, col] = number;
                            if (row != n - counterRowsDown - 1)
                            {
                                number++;
                            }
                            row++;
                        }
                        counter++;
                        counterRowsDown++;
                        row--;
                    }
                    else
                    {
                        while (row >= counterRowsUp)
                        {
                            matrix[row, col] = number;
                            row--;
                            if (row >= counterRowsUp)
                            {
                                number++;
                            }
                        }
                        counter++;
                        counterRowsUp++;
                        row++;
                    }
                }
                else if (counter % 2 == 0)
                {
                    if ((col < n - counterColsRight) && (col != n - counterColsRight - 1))
                    {
                        while (col < n - counterColsRight)
                        {
                            matrix[row, col] = number;
                            if (col != n - counterColsRight - 1)
                            {
                                number++;
                            }
                            col++;
                        }
                        counter++;
                        counterColsRight++;
                        col--;
                    }
                    else
                    {
                        if (col != n - counterColsLeft - 1)
                        {
                            col--;
                        }
                        while (col > counterColsLeft)
                        {
                            matrix[row, col] = number;
                            col--;
                            if (col > counterColsLeft)
                            {
                                number++;
                            }
                        }
                        counter++;
                        counterColsLeft++;
                        col++;
                    }
                }
            }

            for (int i = 0; i < n; i++) //rows
            {
                for (int k = 0; k < n; k++) //cols
                {
                    Console.Write("{0,4}", matrix[i,k] + " ");
                }
                Console.WriteLine();
            }


        }
    }
