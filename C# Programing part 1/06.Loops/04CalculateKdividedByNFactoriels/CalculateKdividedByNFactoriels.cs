using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).

namespace _04CalculateKdividedByNFactoriels
{
    class CalculateKdividedByNFactoriels
    {
        static void Main()
        {
            Console.Write("Enter value for K = ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Enter value for N = ");
            int N = int.Parse(Console.ReadLine());
            int factK = 1;
            int factN = 1;
            double result = 0;
            if ( 1 < K && K < N )
            {
                for (int i = 1; i < K; i++)
                {
                    factK *= i;
                }
                for (int i = 1; i < N; i++)
                {
                    factN *= i;
                }
                result = factN / factK;
                Console.WriteLine("K! = {0}", factK);
                Console.WriteLine("N! = {0}", factN);
                Console.WriteLine("N!/K! = {0}", result);
            }
            else
            {
                Console.WriteLine("Input format should be 1 < K < N!");
            }
        }
    }
}
