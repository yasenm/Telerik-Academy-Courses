// Exercise 08 : Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

// Exercise 09 : Implement an indexer this[row, col] to access the inner matrix cells.

// Exercise 10 : Implement the operators + and - (addition and subtraction of matrices of the same size) 
// and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement
// the true operator (check for non-zero elements).

namespace _08to10TheMatrix
{
    using System;

    class TheMatrix
    {
        // class Matrix is in the file MatrixBody in the assembly
        static void Main()
        {
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            Console.WriteLine("Default Matrix<int>");
            matrix1.PrintMatrix();
            Console.WriteLine("Geting to index by indexer at [1, 1] = {0}", matrix1[1, 1]);
            matrix1[1, 1] = 4;
            Console.WriteLine("After changing the value at the [1, 1] position we find {0}", matrix1[1, 1]);
            Console.WriteLine();

            Matrix<int> matrix2 = new Matrix<int>(3, 3);
            for (int i = 0; i < matrix2.GetRows; i++)
            {
                for (int j = 0; j < matrix2.GetCols; j++)
                {
                    matrix2[i, j] = 2;
                }
            }
            Console.WriteLine("Second matrix made.");
            matrix2.PrintMatrix();
            Console.WriteLine();

            Matrix<int> matrix3 = new Matrix<int>(3, 2);
            for (int i = 0; i < matrix3.GetRows; i++)
            {
                for (int j = 0; j < matrix3.GetCols; j++)
                {
                    matrix3[i, j] = 3;
                }
            }
            Console.WriteLine("Thirt matrix made.");
            matrix3.PrintMatrix();
            Console.WriteLine();

            Matrix<int> resultMatrix1 = matrix1 + matrix2;
            Console.WriteLine("After adding matrix 1 and matrix 2 : ");
            resultMatrix1.PrintMatrix();
            Console.WriteLine();
            Matrix<int> resultMatrix2 = matrix1 - matrix2;
            Console.WriteLine("After substracting matrix 1 and matrix 2 : ");
            resultMatrix2.PrintMatrix();
            Console.WriteLine();
            Matrix<int> resultMatrix3 = matrix2 * matrix3;
            Console.WriteLine("After multiplying matrix 2 and matrix 3 : ");
            resultMatrix3.PrintMatrix();
            Console.WriteLine();
            
        }

    }
}
