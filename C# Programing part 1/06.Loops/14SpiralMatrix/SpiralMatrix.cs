using System;

//Write a program that reads a positive integer number N (N < 20) from console
//and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
//    -Example for N = 4

//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7

namespace _14SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            // seting the console width and height for more convinient view if a bigger number is selected
            Console.WindowHeight = 30;
            Console.BufferHeight = 30;
            Console.WindowWidth = 85;
            Console.BufferWidth = 85;
            Console.WriteLine("Enter parameter for matrix!");
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            int endN = N;                       // end position of rows on witch to enter numbers
            int endM = N;                       // end position of columns on witch to enter numbers
            int startRow = 0;                   // start position of rows on witch to enter numbers
            int startCol = 0;                   // start position of columns on witch to enter numbers
            bool inputPosTopLeft = true;        // that is to declare if we are in the top right position of the matrix
            int startNumber = 1;                // the number that will change the whole time that we will put in the matrix
            int endNumber = N * N;              // the number at which we should stop entering numbers
            int[,] spiralMatrix = new int[N,N]; // matrix that we will put numbers in , in this case 2D matrix
            if (N > 0 && N <= 20)
            {
                while (true)
                {
                    // we check if we are in the top right position of the matrix if so start input from left to right
                    // until columns end and then from top-right to bottom-right until rows end
                    if (inputPosTopLeft == true)
                    {
                        // here we use 2 loops that enter the numbers in the sequence comented 3 lines above
                        for (int i = startRow, j = startCol; j < endN; j++)     // loop that enters numbers in row from left to right
                        {
                            spiralMatrix[i, j] = startNumber;
                            startNumber++;
                        }
                        endN--;
                        for (int i = startCol + 1, j = endN; i < endM; i++)     // loop that enters numbers in column from top to bottom
                        {
                            spiralMatrix[i, j] = startNumber;
                            startNumber++;
                        }
                        endM--;
                        inputPosTopLeft = false;       // we reached the bottomright position so we update that we are there like that
                    }
                    // we check if we are in the bottom-right position if so enter numbers from bottom-right to bottom-left until columns
                    // end and from bottom-left to top-left until rows end
                    else
                    {
                        // here we use 2 loops that enter the numbers in the sequence comented 3 lines above
                        for (int i = endM, j = endN - 1; j > startCol -1; j--)      // loop that enters numbers in row from right to left
                        {
                            spiralMatrix[i, j] = startNumber;
                            startNumber++;
                        }
                        for (int i = endM -1, j = startCol; i > startRow; i--)      // loop that enters numbers in column from bottom to top
                        {
                            spiralMatrix[i, j] = startNumber;
                            startNumber++;
                        }
                        inputPosTopLeft = true;
                        startRow++;     // we update the starting rows and columns for when the next while loop starts
                        startCol++;
                    }
                    // check if the numbers we print should stop printing and the matrix is complete
                    if (startNumber == (endNumber + 1))
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("N should be > 0 and <= 20");
            }
            // loop that prints our matrix in the console
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("|{0,3}|", spiralMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
