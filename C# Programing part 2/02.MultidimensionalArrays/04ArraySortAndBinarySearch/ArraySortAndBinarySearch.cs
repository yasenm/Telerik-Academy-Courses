using System;

//Write a program, that reads from the console an array of N integers
//and an integer K, sorts the array and using the method Array.BinSearch()
//finds the largest number in the array which is ≤ K. 

namespace _04ArraySortAndBinarySearch
{
    class ArraySortAndBinarySearch
    {
        static void Main()
        {
            //generator for random numbers
            Random randomNumber = new Random();

            //initializing parameters of matrix
            Console.Write("Enter value for 'N' = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter value between 1 and 100 for 'K' = ");
            int K = int.Parse(Console.ReadLine());

            //inputing random values for every member in the matrix
            int[] array = new int[N];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = randomNumber.Next(1, 101);
            }

            //print array unsorted
            Console.WriteLine("Unsorted the array is : ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("|{0,3}|", array[i]);
            }
            Console.WriteLine();

            Array.Sort(array);


            //print sorted array
            Console.WriteLine("Sorted the array is : ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("|{0,3}|", array[i]);
            }
            Console.WriteLine();

            //find the largest member from the array that is <= K
            //binary search loop
            int lowerIndex = 0;
            int higherIndex = array.Length - 1;

            while (lowerIndex < higherIndex)
            {
                int mid = lowerIndex + (higherIndex - lowerIndex + 1) / 2;

                if (array[mid] > K)
                {
                    higherIndex = mid - 1;
                }
                else
                {
                    lowerIndex = mid;
                }
            }

            if (array[lowerIndex] > K)
            {
                lowerIndex--;
            }

            if (lowerIndex != -1)
            {
                Console.WriteLine("The number that is <= K = {0} is in position array[{1}]", K, lowerIndex);
            }
            else
            {
                Console.WriteLine("There is no member <= K = {0}", K);
            }

        }
    }
}
