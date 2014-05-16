using System;
using System.Numerics;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

namespace _05CalculateFormula
{
    class CalculateFormula
    {
        static void Main()
        {
            Console.Write("Enter value for K = ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Enter value for N = ");
            int N = int.Parse(Console.ReadLine());
            BigInteger factK = 1;
            BigInteger factN = 1;
            BigInteger result = 0;
            if (1 < N && N < K)
            {
                for (int i = 1; i < K; i++)
                {
                    factK *= i;
                }
                for (int i = 1; i < N; i++)
                {
                    factN *= i;
                }
                result = (factN * factK) / (K - N);
                Console.WriteLine("K! = {0}", factK);
                Console.WriteLine("N! = {0}", factN);
                Console.WriteLine("N! * K! / ( K - N ) = {0}", result);
            }
            else
            {
                Console.WriteLine("Input format should be 1 < N < K!");
            }
        }
    }
}
