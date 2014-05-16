using System;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X, 
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

namespace _06CalculateFormulaNandX
{
    class CalculateFormulaNandX
    {
        static void Main()
        {
            Console.Write("Enter value for N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter value for X = ");
            int X = int.Parse(Console.ReadLine());
            decimal factN = 1m;
            decimal S = 1m;
            for (int i = 1; i <= N; i++)
            {
                S += ( factN / (X * i));
                factN *= i;
            }
            Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … + N!/X*N = {0:0.0000}", S);
        }
    }
}
