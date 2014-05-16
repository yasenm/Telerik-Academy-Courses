using System;

//Write a program that finds the sequence of maximal sum in given array.
//Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?


namespace _08SequenceOfMaximalSum
{
    class SequenceOfMaximalSum
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            Random randomNumber = new Random();

            //---- inputs values in new array 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomNumber.Next(-100, 100);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
            Console.WriteLine();

            //---- solving loop/s
            //---- initialization
            int resultSum = -10;
            int currentSum = 0;
            int counter = 0;
            int resultLength = 0;
            int resultStartIndex = 0;
            //---- the loops
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum = currentSum + arr[j];
                    counter++;
                    if (currentSum > resultSum)
                    {
                        resultSum = currentSum;
                        resultLength = counter;
                        resultStartIndex = i;
                    }
                }
                currentSum = 0;
                counter = 0;
            }
            //---- print the results and result array
            Console.WriteLine("The maximal sum is : {0}", resultSum);
            for (int i = resultStartIndex; i < resultStartIndex + resultLength; i++)
            {
                Console.Write("{0,0:000},", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
