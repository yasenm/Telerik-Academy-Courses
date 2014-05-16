using System;

//Write a program that reads two integer numbers N and K and an array
//of N elements from the console. Find in the array those K 
//elements that have maximal sum.

namespace _06NandK
{
    class NAndK
    {
        static void Main()
        {
            Console.Write("Enter value for 'N' = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter value for 'K' = ");
            int K = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int currentSum = 0;
            int resultSum = 0;

            //---- Enter values in array of N integers
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //---- Start calculating sums
            for (int i = 0; i < arr.Length - K + 1; i++)
            {
                for (int j = i; j < i + K; j++)
                {
                    currentSum = currentSum + arr[j];
                }
                if (currentSum > resultSum)
                {
                    resultSum = currentSum;
                }
                currentSum = 0;
            }
            Console.WriteLine("Biggest sum of {0} members is {1}",K,resultSum);
        }
    }
}
