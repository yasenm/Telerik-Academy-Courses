using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers and finds in
//the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the
//input file contains the size of matrix N. Each of the next N lines contain N numbers separated
//by space. The output should be a single number in a separate text file. Example:
// 4
// 2 3  3 4
// 0 2  3 4   ------->	17
//|3 7| 1 2
//|4 3| 3 2

namespace _05MatrixTextFile
{
    class MatrixTextFile
    {
        //method that calculates and returns result of maximum sum of platform in matrix
        static int CalculateMaxSumInMatrixFromPlatform(int[,] matrix, int platformSize) 
        {
            int result = 0;
            for (int i = 0; i < matrix.GetLength(0) - platformSize + 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - platformSize + 1; j++)
                {
                    int currentSum = 0;
                    for (int indexPlatformX = i; indexPlatformX < i + platformSize; indexPlatformX++)
                    {
                        for (int indexPlatformY = j; indexPlatformY < j + platformSize; indexPlatformY++)
                        {
                            currentSum += matrix[indexPlatformX, indexPlatformY];
                        }
                    }
                    if (currentSum > result)
                    {
                        result = currentSum;
                    }
                }
            }
            return result;
        }

        static void Main()
        {
            //set platform size and get parameter of matrix
            int platformSize = 2;
            int n;
            using (StreamReader sr = new StreamReader("Matrix.txt"))
            {
                string firstLine = sr.ReadLine();
                n = int.Parse(firstLine);
            }
            //we make 2D array and get the matrix from .txt to a array
            int[,] matrix = new int[n, n];
            using (StreamReader sr = new StreamReader("Matrix.txt"))
            {
                string line = sr.ReadLine();
                int row = 0;
                while (line != null)
	            {
                    //with that if we skip the first line
                    string[] stringInts = line.Split(new char[] { ' ' });
                    if (stringInts.Length > 1)
                    {
                        for (int i = 0; i < stringInts.Length; i++)
                        {
                            matrix[row, i] = int.Parse(stringInts[i]);
                        }
                        row++;
                    }
                    line = sr.ReadLine();
	            }
            }
            //find the maximum sum
            Console.WriteLine(CalculateMaxSumInMatrixFromPlatform(matrix,platformSize));
        }
    }
}
