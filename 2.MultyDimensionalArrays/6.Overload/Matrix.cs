using System;
using System.Collections.Generic;
class Matrix
{
    private int[,] matrix;

    public Matrix (int rows, int cols)
    {
        this.matrix = new int[rows,cols];
    }

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0); 
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    //overloading the operator +
    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }

        return result;
    }

    //indexer for accessing the matrix content
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    //overloading the operator -
    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }
        return result;
    }

    //overloading the operator *
    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, second.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            int rowCopy = 0;

            for (int col = 0; col < second.Cols; col++)
            {
                int colCopy = 0;
                int n = first.Cols;
                while(n>0)
                {
                    result[row, col] += first[row, colCopy] * second[colCopy, rowCopy];
                    colCopy++;
                    n--;
                }
                rowCopy++;
            }
        }
        return result;
    }

    //overloading the ToString() method = to write a method that prints your matrix:
    public override string ToString()
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                Console.Write("{0,4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
        return result;
    }

        
}
