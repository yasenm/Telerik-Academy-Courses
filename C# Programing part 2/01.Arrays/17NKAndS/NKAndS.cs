using System;

//* Write a program that reads three integer numbers N, K and S and an array
//of N elements from the console. Find in the array a subset of K elements
//that have sum S or indicate about its absence.

namespace _17NKAndS
{
    class NKAndS
    {
        static void Main()
        {
            //------------------------------------------------------------------------------
            //    I used same algorithm as last exercise it's prety fast in my opignion
            //------------------------------------------------------------------------------

            //Reading part of the console that sets the main variables
            Console.Write("Enter value for N : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter value for K : ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Enter value for S : ");
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] arrayOfN = new int[N];
            for (int i = 0; i < arrayOfN.Length; i++)
			{
                Console.Write("arrOfN[{0}] = ", i);
			    arrayOfN[i] = int.Parse(Console.ReadLine());
			}

            //Variables that we will use in the solving
            bool thereIsSuchASum = false;
            int counterForK = 0;
            int result = 0;
            int targetSum = S;
            //Sets and checkings
            int limit = (2 << (N - 1)) - 1;
            for (int i = 1; i <= limit; i++)
            {
                int currentSum = 0;
                for (int bitIndex = 0; bitIndex < N; bitIndex++)
                {
                    if (((i >> bitIndex) & 1) == 1)
                    {
                        currentSum += arrayOfN[bitIndex];
                        counterForK++;
                    }
                }
                if (counterForK == K)
                {
                    if (currentSum == targetSum)
                    {
                        result++;
                        thereIsSuchASum = true;
                    }
                }
                counterForK = 0;
            }
            Console.WriteLine(thereIsSuchASum?"There is such a sum!":"There isn't such a sum!");
        }
    }
}
