using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

//// a)  1 | 5 | 9 | 13|            b)  1 | 8 | 9 | 16|
//       2 | 6 | 10| 14|                2 | 7 | 10| 15|
//       3 | 7 | 11| 15|                3 | 6 | 11| 14|
//       4 | 8 | 12| 16|                4 | 5 | 12| 13|

//// c)  7 | 11| 14| 16|            d)* 1 | 12| 11| 10|
//       4 | 8 | 12| 15|                2 | 13| 16| 9 |
//       2 | 5 | 9 | 13|                3 | 14| 15| 8 |
//       1 | 3 | 6 | 10|                4 | 5 | 6 | 7 |

namespace _01PrintingDiferentTypeMatrixes
{
    class PrintingDiferentTypeMatrixes
    {
        static void Main()
        {
            //----------------------------------------
            //          Exercise 1 : a)
            //----------------------------------------
            Console.WriteLine("Exercise 1 : a)");
            Console.Write("Enter value for 'N' rows and cols in matrix : ");
            int NA = int.Parse(Console.ReadLine());

            int inputValueA = 1;
            int[,] resultArrayA = new int[NA, NA];
            for (int i = 0; i < resultArrayA.GetLength(1); i++)
            {
                for (int j = 0; j < resultArrayA.GetLength(0); j++)
                {
                    resultArrayA[j, i] = inputValueA;
                    inputValueA++;
                }
            }

            for (int i = 0; i < resultArrayA.GetLength(0); i++)
            {
                for (int j = 0; j < resultArrayA.GetLength(1); j++)
                {
                    Console.Write("|{0,3}|", resultArrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            //          Exercise 1 : b)
            //----------------------------------------
            Console.WriteLine("Exercise 1 : b)");
            Console.Write("Enter value for 'N' rows and cols in matrix : ");
            int NB = int.Parse(Console.ReadLine());

            int inputValueB = 1;
            bool goDown = true;
            int[,] resultArrayB = new int[NB,NB];
            // 'i' will represent columns and 'j' rows
            for (int i = 0; i < resultArrayB.GetLength(0); i++)
            {
                //if goDown direction == true start entering values from top to bottom
                if (goDown)
                {
                    for (int j = 0; j < resultArrayB.GetLength(1); j++)
                    {
                        resultArrayB[j,i] = inputValueB;
                        inputValueB++;
                        if (inputValueB % resultArrayB.GetLength(0) == 0)
                        {
                            goDown = false;
                        }
                    }
                }
                // else start writing from bottom to top
                else
                {
                    for (int j = resultArrayB.GetLength(1) - 1; j >= 0; j--)
                    {
                        resultArrayB[j, i] = inputValueB;
                        inputValueB++;
                        if (inputValueB % resultArrayB.GetLength(0) == 0)
                        {
                            goDown = true;
                        }
                    }
                }
            }
            //Print result
            for (int i = 0; i < resultArrayB.GetLength(0); i++)
            {
                for (int j = 0; j < resultArrayB.GetLength(1); j++)
                {
                    Console.Write("|{0,3}|", resultArrayB[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            //          Exercise 1 : c)
            //----------------------------------------
            Console.WriteLine("Exercise 1 : c)");
            Console.Write("Enter value for 'N' rows and cols in matrix : ");
            int NC = int.Parse(Console.ReadLine());

            int inputValueC = 1;
            int[,] resultArrayC = new int[NC, NC];
            for (int i = 0; i < NC; i++)
            {
                for (int j = 0; j <= i; j++) 
                {
                    resultArrayC[NC - i + j - 1, j] = inputValueC;
                    inputValueC++;
                }
            
            }

            for (int i = NC - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--) 
                {
                    resultArrayC[i - j, NC - j - 1] = inputValueC;
                    inputValueC++;
                }
                
            }
            //Print result
            for (int i = 0; i < resultArrayC.GetLength(0); i++)
            {
                for (int j = 0; j < resultArrayC.GetLength(1); j++)
                {
                    Console.Write("|{0,3}|", resultArrayC[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //----------------------------------------
            //          Exercise 1 : d)
            //----------------------------------------
            Console.WriteLine("Exercise 1 : d)");
            Console.Write("Enter value for 'N' rows and cols in matrix : ");
            int ND = int.Parse(Console.ReadLine());
            int endRow = ND;                        // end position of rows on witch to enter numbers
            int endCol = ND;                        // end position of columns on witch to enter numbers
            int startRow = 0;                       // start position of rows on witch to enter numbers
            int startCol = 0;                       // start position of columns on witch to enter numbers
            bool inputPosTopLeft = true;            // that is to declare if we are in the top right position of the matrix
            int startNumber = 1;                    // the number that will change the whole time that we will put in the matrix
            int endNumber = ND * ND;                // the number at which we should stop entering numbers
            int[,] spiralMatrix = new int[ND, ND];  // matrix that we will put numbers in , in this case 2D matrix
            while (true)
            {
                // we check if we are in the top right position of the matrix if so start input from left to right
                // until columns end and then from top-right to bottom-right until rows end
                if (inputPosTopLeft == true)
                {
                    // here we use 2 loops that enter the numbers in the sequence comented 3 lines above
                    for (int i = startRow, j = startCol; j < endRow; j++)     // loop that enters numbers in row from left to right
                    {
                        spiralMatrix[i, j] = startNumber;
                        startNumber++;
                    }
                    endRow--;
                    for (int i = startCol + 1, j = endRow; i < endCol; i++)     // loop that enters numbers in column from top to bottom
                    {
                        spiralMatrix[i, j] = startNumber;
                        startNumber++;
                    }
                    endCol--;
                    inputPosTopLeft = false;       // we reached the bottomright position so we update that we are there like that
                }
                // we check if we are in the bottom-right position if so enter numbers from bottom-right to bottom-left until columns
                // end and from bottom-left to top-left until rows end
                else
                {
                    // here we use 2 loops that enter the numbers in the sequence comented 3 lines above
                    for (int i = endRow, j = endRow - 1; j > startCol - 1; j--)      // loop that enters numbers in row from right to left
                    {
                        spiralMatrix[i, j] = startNumber;
                        startNumber++;
                    }
                    for (int i = endRow - 1, j = startCol; i > startRow; i--)      // loop that enters numbers in column from bottom to top
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
            // loop that prints our matrix in the console
            for (int i = 0; i < ND; i++)
            {
                for (int j = 0; j < ND; j++)
                {
                    Console.Write("|{0,3}|", spiralMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
