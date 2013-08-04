using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(3, 3);
        matrix1[0, 0] = 2;
        matrix1[0, 1] = 5;
        matrix1[1, 1] = 3;
        matrix1[2, 0] = -7;
        matrix1[2, 2] = 11;
        Matrix matrix2 = new Matrix(3, 3);
        matrix2[0, 1] = -3;
        matrix2[0, 2] = -7;
        matrix2[1, 0] = 2;
        matrix2[1, 1] = 1;
        matrix2[2, 0] = -3;
        matrix2[2, 1] = 4;

        Matrix sum = matrix1 + matrix2;
        //PrintMatrix(sum);
        Console.WriteLine(sum.ToString());

        Matrix subtract = matrix1 - matrix2;
        PrintMatrix(subtract);
        //Console.WriteLine(subtract.ToString());
        Console.WriteLine();

        Matrix multiply = matrix1 * matrix2;
        PrintMatrix(multiply);
        //Console.WriteLine(multiply.ToString());
    }

    private static void PrintMatrix(Matrix result)
    {
        for (int row = 0; row < result.Rows; row++)
        {
            for (int col = 0; col < result.Cols; col++)
            {
                Console.Write("{0,4}", result[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
