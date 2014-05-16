﻿using System;


class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols) 
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

    public int Columns 
    {
        get 
        {
            return this.matrix.GetLength(1);
        }
    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows,first.Columns);
        // Check for same dimensions
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Columns; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }
        return result;
    }

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

    static void PrintMatrix(Matrix matrix) 
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Columns; col++)
            {
                Console.Write("{0,3}",matrix[row,col]);
            }
            Console.WriteLine();
        }
    }

    public override string ToString()
    {
        string result = null;

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Columns; col++)
            {
                result += this[row, col] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}
