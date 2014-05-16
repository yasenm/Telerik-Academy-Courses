using System;
using System.Numerics;

//* We are given an array of integers and a number S. Write a program to find if
//there exists a subset of the elements of the array that has a sum S.
//Example:
//arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

namespace _16CombinatoricSumSFromArray
{
    class CombinatoricSumSFromArray
    {
        static void Main()
        {
            ////user input values
            //BigInteger S = BigInteger.Parse(Console.ReadLine());
            //int N = int.Parse(Console.ReadLine());

            //default input values
            BigInteger S = 14;
            int N = 8;

            int[] setOfN = new int[N];
            //For loop to input the set of numbers
            Console.WriteLine("Enter 8 members of array");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Enter vlaue for arr[{0}] : ");
                setOfN[i] = int.Parse(Console.ReadLine());
            }

            //variables that we will use in the solving
            bool thereIsSuchASum = false;
            int result = 0;
            BigInteger targetSum = S;
            //limit will set the number of combinations we will have depending on 'N'
            int limit = (2 << (N - 1)) - 1;
            //We will run loop from 1 to limit and check every possible combination there is
            //for this amount of array members
            for (int i = 1; i <= limit; i++)
            {
                //We set a sum as 0 to add on every member from the combination and clear
                BigInteger currentSum = 0;
                //The combinations are represented by the bit representations of the posible combinations
                //for example when we are at i = 7 , i bitwise is = 101 , so we take the position of the 1's
                //in this case positions 0 and 2 and make sum from the members 0 and 2 from the array and etc.
                //for every next 'i'
                for (int bitIndex = 0; bitIndex < N; bitIndex++)
                {
                    if (((i >> bitIndex) & 1) == 1)
                    {
                        currentSum += setOfN[bitIndex];
                    }
                }
                //After each combination sum we check if there is such we count it and make thereIsSuchASum = true
                //since we have encountered such combination
                if (currentSum == targetSum)
                {
                    result++;
                    thereIsSuchASum = true;
                }
            }
            Console.WriteLine("Is there a sub set of that sum? -----> {0}",thereIsSuchASum);
            Console.WriteLine("Number of times we encounter subset with same sum is : {0}",result);
        }
    }
}
