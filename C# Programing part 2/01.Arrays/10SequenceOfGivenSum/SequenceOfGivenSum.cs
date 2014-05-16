using System;

//Write a program that finds in given array of integers a sequence of
//given sum S (if present). 
//Example:
//{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

namespace _10SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            //---- Enter values in array of N integers
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //---- Enter 'S' sum that we are looking for if there is a sequence that is equal to it
            Console.Write("Enter 'S' sum to search a suqence for : ");
            int S = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int endIndex = 0;
            int counter = 0;
            int counterLen = 0;
            bool thereIsSequence = false;

            //---- loops to find if there is suck a sum
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    counter++;
                    if (currentSum == S)
                    {
                        endIndex = j + 1;
                        counterLen = counter;
                        thereIsSequence = true;
                    }
                }
                currentSum = 0;
                counter = 0;
            }
            //---- print results
            //---- check if there is such a sequence
            if (thereIsSequence)
            {
                Console.WriteLine("There is such a sequence!");
                //---- print the part of array that gives the same sum 'S'
                for (int i = endIndex - counterLen; i < endIndex; i++)
                {
                    Console.Write("{0,0:000},", arr[i]);
                }
            }
            else
            {
                Console.WriteLine("There isn't such a sequence!");
            }

        }
    }
}
