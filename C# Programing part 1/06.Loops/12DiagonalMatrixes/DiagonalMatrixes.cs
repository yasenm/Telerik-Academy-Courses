using System;

//Write a program that reads from the console a positive integer
//number N (N < 20) and outputs a matrix like the following:
//1 2 3
//2 3 4
//3 4 5

namespace _12DiagonalMatrixes
{
    class DiagonalMatrixes
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
            if ( N > 0 && N <= 20 )
            {
                // loop that enters us to a row 'i'
                for (int i = 0; i < N; i++)
                {
                    // loop that starts to write on row 'i' and every next row starts with 'i + 1'
                    for (int j = i + 1; j <= N + i; j++)
                    {
                        Console.Write("|{0,2}|", j);
                    }
                    // moves us to a new line for write in console
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("N should be > 0 and <= 20");
            }
        }
    }
}
