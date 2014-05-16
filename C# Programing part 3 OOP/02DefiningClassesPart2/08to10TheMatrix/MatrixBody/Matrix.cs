using System;

public class Matrix<T>
{
    #region Exercise 08 : Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
    public int Rows { get; set; }
    public int Cols { get; set; }
    private T[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.Rows = rows;
        this.Cols = cols;
        this.matrix = new T[Rows, Cols];
    }

    public int GetRows
    {
        get
        {
            return this.Rows;
        }
    }

    public int GetCols
    {
        get
        {
            return this.Cols;
        }
    }
    #endregion

    #region Exercise 09 : Implement an indexer this[row, col] to access the inner matrix cells.
    public T this[int row, int col]
    {
        get 
        {
            if (row < 0 || col < 0 || row > this.Rows || col > this.Cols)
            {
                throw new IndexOutOfRangeException(String.Format("One or two indexex is out of matrix parameters range. Chose new indexes! Matrix parameters [{0}, {1}]. While trying to access position [{2}, {3}]", this.Rows, this.Cols, row, col));
            }
            return matrix[row, col];
        }
        set 
        {
            if (row < 0 || col < 0 || row > this.Rows || col > this.Cols)
            {
                throw new IndexOutOfRangeException(String.Format("One or two indexex is out of matrix parameters range. Chose new indexes! Matrix parameters [{0}, {1}]. While trying to access position [{2}, {3}]", this.Rows, this.Cols, row, col));
            }
            matrix[row, col] = value;
        }
    }
    #endregion

    #region Exercise 10 : Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

    public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.GetRows != secondMatrix.GetCols || firstMatrix.GetCols != secondMatrix.GetCols)
        {
            throw new IndexOutOfRangeException(String.Format("Cannot add matrices with different sizes in this case matrix1[{0}, {1}] and matrix2[{2}, {3}]", firstMatrix.GetRows, firstMatrix.GetCols, secondMatrix.GetRows, secondMatrix.GetCols));
        }
        Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetRows, firstMatrix.GetCols);
        for (int row = 0; row < firstMatrix.GetRows; row++)
        {
            for (int col = 0; col < firstMatrix.GetCols; col++)
            {
                dynamic firstVar = firstMatrix[row, col];
                resultMatrix[row, col] = firstVar + secondMatrix[row, col];
            }
        }
        return resultMatrix;
    }

    public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.GetRows != secondMatrix.GetCols || firstMatrix.GetCols != secondMatrix.GetCols)
        {
            throw new IndexOutOfRangeException(String.Format("Cannot substract matrices with different sizes in this case matrix1[{0}, {1}] and matrix2[{2}, {3}]", firstMatrix.GetRows, firstMatrix.GetCols, secondMatrix.GetRows, secondMatrix.GetCols));
        }
        Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetRows, firstMatrix.GetCols);
        for (int row = 0; row < firstMatrix.GetRows; row++)
        {
            for (int col = 0; col < firstMatrix.GetCols; col++)
            {
                dynamic firstVar = firstMatrix[row, col];
                resultMatrix[row, col] = firstVar - secondMatrix[row, col];
            }
        }
        return resultMatrix;
    }

    public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
    {
        if (firstMatrix.GetCols != secondMatrix.GetRows)
        {
            throw new IndexOutOfRangeException(String.Format("Cannot multiply matrices with different sizes of matrix1 columns {0} and matrix2 rows {1} they should be equal!", firstMatrix.GetCols, secondMatrix.GetRows));
        }
        Matrix<T> resultMatrix = new Matrix<T>(firstMatrix.GetRows, secondMatrix.GetCols);
        for (int row = 0; row < firstMatrix.GetRows; row++)
        {
            // here we enter the loop to make new matrix size and enter the second matrix columns from which we have to multiply
            for (int x = 0; x < secondMatrix.GetCols; x++)
			{
                for (int col = 0; col < firstMatrix.GetCols; col++)
                {
                    resultMatrix[row, x] += (dynamic)firstMatrix[row, col] * (dynamic)secondMatrix[col, x];
                }
			}
        }
        return resultMatrix;

    }

    public static bool operator true(Matrix<T> matrix)
    {
        if (matrix == null || matrix.GetRows == 0 || matrix.GetCols == 0)
        {
            return false;
        }

        for (int row = 0; row < matrix.GetRows; row++)
        {
            for (int col = 0; col < matrix.GetCols; col++)
            {
                // if the matrix finds that an element is not equal to to default(T) we get false witch we are looking for
                // in that case we put the "!" infront so we make it true and return true for the matrix same in reverse
                // for the operator false
                if (!matrix[row, col].Equals(default(T)))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        if (matrix == null || matrix.GetRows == 0 || matrix.GetCols == 0)
        {
            return true;
        }

        for (int row = 0; row < matrix.GetRows; row++)
        {
            for (int col = 0; col < matrix.GetCols; col++)
            {
                if (!matrix[row, col].Equals(default(T)))
                {
                    return false;
                }
            }
        }
        return true;

    }
    #endregion

    public void PrintMatrix() 
    {
        for (int row = 0; row < this.Rows; row++)
        {
            string line = "|";
            for (int col = 0; col < this.Cols; col++)
            {
                line += matrix[row, col] + "|";
            }
            Console.WriteLine(line);
        }
    }
}
