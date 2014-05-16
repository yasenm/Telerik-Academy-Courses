using System;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

namespace _13SortWithMergeSortRecursive
{
    class SortWithMergeSortRecursive
    {
        //---- Merge method for 2 arrays as input
        static int[] Merge(int[] left, int[] right)
        {
            //---- The result that we will get and use in the MergeSort method
            int[] result = new int[left.Length + right.Length];

            //---- sorting the 2 inputed arrays
            for (int inputPositionIndex = 0, i = 0, j = 0; inputPositionIndex < result.Length; inputPositionIndex++,i++, j++)
            {
                if (i == left.Length)
                {
                    result[inputPositionIndex] = right[j];
                    i--;
                }
                else if (j == right.Length)
                {
                    result[inputPositionIndex] = left[i];
                    j--;
                }
                else if (left[i] < right[j])
                {
                    result[inputPositionIndex] = left[i];
                    j--;
                }
                else
                {
                    result[inputPositionIndex] = right[j];
                    i--;
                }
            }

            return result;
        }
        //---- Merge sort method
        static int[] MergeSort(int[] arrayToSort) 
        {
            //---- First we check the length of the input data array and if it is 1 or 0 start 
            //---- back steping recursivly
            if (arrayToSort.Length <= 1)
            {
                return arrayToSort;
            }
            //---- Local variables that will hold the main parameter values
            int midle = arrayToSort.Length / 2;
            int len = arrayToSort.Length - midle;
            //---- The arrays that we will work with afterwards
            int[] left = new int[midle];
            int[] right = new int[len];
            //---- input values in the new arrays left and right
            for (int i = 0; i < midle; i++)
            {
                left[i] = arrayToSort[i];
            }
            for (int i = 0, j = midle; i < len; i++,j++)
            {
                right[i] = arrayToSort[j];
            }

            //---- the merging part we call merge method that will get a unsorted array and 
            //---- return a sorted one
            left = MergeSort(left);
            right = MergeSort(right);

            //---- The recursive part that will triger again the same function we are in
            int[] result = Merge(left, right);

            return result;
        }
        static void Main()
        {
            //---- input data for exercise
            //---- with a given array
            //int[] unsortedArray = { 9, 2, 6, 5, 3, 10, 1, 7 };

            //---- with random making of array with numbers between 0 and 100
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[N];
            Random randomNumber = new Random();

            //---- input values in unsorted array 
            Console.WriteLine("Unsorted the array is : ");
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = randomNumber.Next(0, 100);
            }

            //---- output data that we will print
            int[] sortedArray = new int[unsortedArray.Length];

            //---- Print unsorted array
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                Console.Write("{0,0:000},", unsortedArray[i]);
            }
            Console.WriteLine();

            //---- Call the MergeSort method
            sortedArray = MergeSort(unsortedArray);

            //---- printing result array a.k.a. sortedArray
            Console.WriteLine("Sorted the array is : ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write("{0,0:000},", sortedArray[i]);
            }
            Console.WriteLine();
        }
    }
}
