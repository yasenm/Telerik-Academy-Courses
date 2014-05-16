using System;

//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "selection sort" 
//algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

namespace _07SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            Console.Write("Enter length of array : ");
            int N = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[N];
            Random randomNumber = new Random();

            //---- input values in unsorted array 
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = randomNumber.Next(0,100);
            }
            for (int i = 0; i < unsortedArray.Length; i++)
			{
                Console.Write("{0,0:000},",unsortedArray[i]);
			}
            Console.WriteLine();

            //---- sorting part of exercise

            //---- initialization of solving part
            int[] sortedArray = new int[N];
            int lowerIndexer = 0;
            int tempHolder = 0;
            //---- start of sorting sequence
            //---- first we enter the first member of the unsorted array
            for (int i = 0; i < sortedArray.Length; i++)
            {
                //---- we give the lowerIndexer 'i' as a value
                lowerIndexer = i;
                for (int nextIndex = 1 + i; nextIndex < sortedArray.Length; nextIndex++)
                {
                    //---- if the previous member is bigger than the next one we 
                    //---- switch their indexes and after that positions with temp holders
                    if (unsortedArray[lowerIndexer] > unsortedArray[nextIndex])
                    {
                        lowerIndexer = nextIndex;
                    }
                }
                //---- the tempHolder holds the lower integer and pu
                tempHolder = unsortedArray[lowerIndexer];
                unsortedArray[lowerIndexer] = unsortedArray[i];
                sortedArray[i] = tempHolder;
            }
            //---- printing result array a.k.a. sortedArray
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write("{0,0:000},", sortedArray[i]);
            }
            Console.WriteLine();
        }
    }
}
