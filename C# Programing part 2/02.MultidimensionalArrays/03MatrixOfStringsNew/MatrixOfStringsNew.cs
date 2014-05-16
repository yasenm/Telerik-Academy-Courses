using System;
using System.Collections.Generic;

//We are given a matrix of strings of size N x M. Sequences in
//the matrix we define as sets of several neighbor elements 
//locatedon the same line, column or diagonal. Write a program
//that finds the longest sequence of equal strings in the matrix.
//Example:

//"ha" ,"fifi","ho","hi"
//"fo" ,"ha"  ,"hi","xx"
//"xxx","fifi","ha","xx"

//answer : "ha", "ha", "ha";

namespace _03MatrixOfStringsNew
{
    class MatrixOfStringsNew
    {
        static void Main()
        {
            //Console.Write("Enter 'N' for rows in string matrix : ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter 'M' for rows in string matrix : ");
            //int cols = int.Parse(Console.ReadLine());

            //string[,] stringMatrix = new string[rows,cols];
            //for (int i = 0; i < stringMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < stringMatrix.GetLength(1); j++)
            //    {
            //        Console.Write("Enter string for matrix[{0},{1}]",i,j);
            //        string inputString = Console.ReadLine();
            //        stringMatrix[i,j] = inputString;
            //    }
            //    Console.WriteLine();

            //like example from the presentation

            //seted up matrix uncomment previous lines for more user dinamic input
            string[,] stringMatrix = {
                                     {"ha" ,"fifi","xxx","hi"},
                                     {"fo" ,"xxx"  ,"hi","xx"},
                                     {"xxx","fifi","ha","xx"},
                                     };

            //Print matrix
            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(1); j++)
                {
                    Console.Write("|{0,4}|", stringMatrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //examing the array , counting and finding the sequence
            List<string> resultList = new List<string>();
            List<string> tempList = new List<string>();

            //first we need to examin sequence from left to right that will examin all the horizontal
            //sequences
            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(1) - 1; j++)
                {
                    for (int nextRight = j; nextRight < stringMatrix.GetLength(1); nextRight++)
                    {
                        if (stringMatrix[i, j] == stringMatrix[i, nextRight])
                        {
                            tempList.Add(stringMatrix[i, j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempList.Count > resultList.Count)
                    {
                        resultList.Clear();
                        foreach (var item in tempList)
                        {
                            resultList.Add(item);
                        }
                    }
                    tempList.Clear();
                }
            }

            //Second time we are examining vertikal sequences
            for (int i = 0; i < stringMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(1); j++)
                {
                    for (int nextDown = i; nextDown < stringMatrix.GetLength(0); nextDown++)
                    {
                        if (stringMatrix[i, j] == stringMatrix[nextDown, j])
                        {
                            tempList.Add(stringMatrix[nextDown, j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempList.Count > resultList.Count)
                    {
                        resultList.Clear();
                        foreach (var item in tempList)
                        {
                            resultList.Add(item);
                        }
                    }
                    tempList.Clear();
                }
            }

            //Thirth and fourth are the two diagonal possibilities
            //Thirth from top-left to bottom-right
            for (int j = 0; j < stringMatrix.GetLength(1) - 1; j++)
            {
                int diagonalEndingCoeficient = 0;
                if (j >= stringMatrix.GetLength(0))
                {
                    diagonalEndingCoeficient = stringMatrix.GetLength(0) - j - 1;
                }
                for (int i = 0; i < stringMatrix.GetLength(0) - diagonalEndingCoeficient - 1; i++)
                {
                    for (int diagonalI = i, diagonalJ = j; diagonalI < stringMatrix.GetLength(0) - diagonalEndingCoeficient; diagonalI++, diagonalJ++)
                    {
                        if (stringMatrix[i,j] == stringMatrix[diagonalI,diagonalJ])
                        {
                            tempList.Add(stringMatrix[diagonalI, diagonalJ]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempList.Count > resultList.Count)
                    {
                        resultList.Clear();
                        foreach (var item in tempList)
                        {
                            resultList.Add(item);
                        }
                    }
                    tempList.Clear();
                }
            }

            //Fourth move from bottom-left to top-right diagonaly
            for (int j = 0; j < stringMatrix.GetLength(1) - 1; j++)
            {
                for (int i = 1; i < stringMatrix.GetLength(0); i++)
                {
                    int diagonalEndingCoeficient = 0;
                    if (j >= stringMatrix.GetLength(0))
                    {
                        diagonalEndingCoeficient = stringMatrix.GetLength(0) - j - 1;
                    }
                    for (int diagonalI = i, diagonalJ = j; diagonalI >= 0 + diagonalEndingCoeficient*(-1); diagonalI--, diagonalJ++)
                    {
                        if (stringMatrix[i, j] == stringMatrix[diagonalI, diagonalJ])
                        {
                            tempList.Add(stringMatrix[diagonalI, diagonalJ]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (tempList.Count > resultList.Count)
                    {
                        resultList.Clear();
                        foreach (var item in tempList)
                        {
                            resultList.Add(item);
                        }
                    }
                    tempList.Clear();
                }
            }
            Console.WriteLine();

            //print result list
            Console.WriteLine("Largest sequence is : ");
            for (int i = 0; i < resultList.Count; i++)
            {
                Console.Write("|{0}|",resultList[i]);
            }
            Console.WriteLine();
        }
    }
}
