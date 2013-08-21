//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2x2 with maximal sum
//of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contains N numbers separated by space.
//The output should be a single number in a separate text file. Example:
//  4
//  2 3 3 4
//  0 2 3 4     --------->  17
//  3 7 1 2
//  4 3 3 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
    class MatrixFromFile
    {
        static void Main()
        {
            StreamReader input = new StreamReader("matrix.txt");
            using (input)
            {
                StreamWriter output = new StreamWriter("output.txt");
                using (output)
                {
                    try
                    {
                        string line = input.ReadLine();
                        int n = int.Parse(line);
                        int[,] matrix = new int[n, n];
                        for (int i = 0; i < n; i++)  //adding the numbers from the file to a matrix of integers
                        {
                            line = input.ReadLine();
                            string[] nums = line.Split(' ');
                            for (int k = 0; k < nums.Length; k++)
                            {
                                matrix[i, k] = int.Parse(nums[k]);
                            }
                        }
                        int maxSum = int.MinValue;
                        int currentSum = 0;
                        int startCol = 0;
                        int startRow = 0;
                        while (startCol < n - 1 && startRow < n - 1)
                        {
                            for (int i = startRow; i < startRow + 2; i++)
                            {
                                for (int k = startCol; k < startCol + 2; k++)
                                {
                                    currentSum += matrix[i, k];
                                }
                            }
                            if (currentSum > maxSum)
                            {
                                maxSum = currentSum;
                            }
                            currentSum = 0;
                            startCol++;
                            if (startCol == n - 1 && startRow < n)
                            {
                                startCol = 0;
                                startRow++;
                            }
                        }
                        output.WriteLine("Maximal sum of 2x2 area in the matrix = {0}", maxSum);
                    }
                    catch (FileNotFoundException)
                    {
                        output.WriteLine("Input file is missing!");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        output.WriteLine("Your matrix is not square or your number of lines in the matrix is incorrect!");
                    }
                }
            }
        }
    }
