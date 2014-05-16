using System;

//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

namespace _02SquareWithMaximalSum
{
    class SquareWithMaximalSum
    {
        static void Main()
        {
            //generator for random numbers
            Random randomNumber = new Random();

            //initializing parameters of matrix
            Console.Write("Enter value for 'N' rows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter value for 'M' cols = ");
            int cols = int.Parse(Console.ReadLine());

            //inputing random values for every member in the matrix
            int[,] matrix = new int[rows,cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = randomNumber.Next(1,101);
                }
            }

            //print matrix to check sum on the console
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("|{0,3}|", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //initialize platform parameters
            Console.Write("Enter width of platform : ");
            int widthPlatform = int.Parse(Console.ReadLine());
            Console.Write("Enter height of platform : ");
            int heightPlatform = int.Parse(Console.ReadLine());
            int resultSum = 0;

            //Solving algorithm
            for (int i = 0; i < matrix.GetLength(0) - widthPlatform - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - heightPlatform - 1; j++)
                {
                    // i and j starting of platform
                    int currentSum = 0;

                    for (int indexPlatformX = i; indexPlatformX < i + widthPlatform; indexPlatformX++)
                    {
                        for (int indexPlatformY = j; indexPlatformY < j + heightPlatform; indexPlatformY++)
                        {
                            currentSum += matrix[i,j];
                        }
                    }

                    if (currentSum > resultSum)
                    {
                        resultSum = currentSum;
                    }
                }
            }
            Console.WriteLine("Maximal sum is : {0,3};", resultSum);
        }
    }
}
